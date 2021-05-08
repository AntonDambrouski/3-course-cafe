﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void doBacklabel_Click(object sender, EventArgs e)
        {
            this.Hide();

            Cafe authorization = new Cafe();
            authorization.Show();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadDishes_Click(object sender, EventArgs e)
        {
            try
            {
                Administration_form.TableLoader.LoadDishesTable(this.dataGridView1, out string[] searchBy);
                LoadComboBoxSearchBy(searchBy);
                ActivateDishesElements();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActivateDishesElements()
        {
            buttonAddDishes.Enabled = buttonDelDishes.Enabled = buttonPrintDishesTable.Enabled = buttonSaveDishesTable.Enabled = buttonSendDishesTable.Enabled = true;
            textBoxDishesSearch.Enabled = comboBoxDishesSearchBy.Enabled = true;
        }

        private void LoadComboBoxSearchBy(string[] searchByValues)
        {
            comboBoxDishesSearchBy.Items.Clear();
            comboBoxDishesSearchBy.Items.AddRange(searchByValues);
        }

        private void buttonAddDishes_Click(object sender, EventArgs e)
        {
            Add_dish add_Dish = new Add_dish();
            if (add_Dish.ShowDialog() == DialogResult.OK)
            {
                buttonLoadDishes_Click(null, null);
            }
        }

        private void buttonDelDishes_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Administration_form.TableLoader.SaveChanges();
        }

        private void textBoxDishesSearch_TextChanged(object sender, EventArgs e)
        {
            labelDishesSearchError.Text = string.Empty;
            if (textBoxDishesSearch.Text.Length != 0)
            {
                try
                {
                    if (comboBoxDishesSearchBy.SelectedItem is null)
                    {
                        throw new ArgumentException("Не выбрано поле для поиска!");
                    }

                    if (long.TryParse(textBoxDishesSearch.Text, out long valueType))
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"{comboBoxDishesSearchBy.SelectedItem} = '{textBoxDishesSearch.Text}'";
                    }
                    else
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"{comboBoxDishesSearchBy.SelectedItem} LIKE N'%{textBoxDishesSearch.Text}%'";
                    }

                }
                catch (ArgumentException ex)
                {
                    labelDishesSearchError.Text = ex.Message;
                }
                catch (Exception ex)
                {
                    labelDishesSearchError.Text = "Некоррекнтые данные!";
                }
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
        }

        private void buttonSaveDishesTable_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "Dishes.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Additional_buttons.SaveTableInWord.Export_Data_To_Word(dataGridView1, sfd.FileName, "Dishes");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSendDishesTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Additional_buttons.SendTableOnEmail.IsConnectedToInternet())
                {
                    throw new Exception("Нет подключения к интернету");
                }

                Add_forms.InputEmailForm inputEmail = new Add_forms.InputEmailForm();
                if (inputEmail.ShowDialog() == DialogResult.OK)
                {
                    Additional_buttons.SendTableOnEmail.IsValidEmail(inputEmail.textBoxEmail.Text);
                    Additional_buttons.SendTableOnEmail.SendEmail(dataGridView1, inputEmail.textBoxEmail.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Send error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrintDishesTable_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK && printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Additional_buttons.PrintTable.GetBmpForPrint(dataGridView1, printDocument1.DefaultPageSettings.Bounds), 0, 0);
        }
    }
}