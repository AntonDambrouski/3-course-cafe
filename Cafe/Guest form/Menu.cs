using System;
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
    public partial class Menu : Form
    {
        List<Guest_form.basket> basket = new List<Guest_form.basket>();
        Guest_form.User user = null;
        public Menu(Guest_form.User user)
        {
            this.user = user;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonShowDishes_Click(object sender, EventArgs e)
        {
            try
            {
                //  ClearSearchFiealds();
                Guest_form.GuestTableLoader.LoadDishesTable(this.dataGridView1, out string[] searchBy);
                ChangeEnabledOfDishesElements(true);
                ChangeEnabledOfBasketElements(false);
                LoadComboBoxSearchBy(comboBoxDishesSearchBy, searchBy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxSearchBy(ComboBox comboBox, string[] searchBy)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(searchBy);
        }

        private void ChangeEnabledOfDishesElements(bool enabled)
        {
            buttonAddToBasket.Enabled = comboBoxDishesSearchBy.Enabled = textBoxDishesSearch.Enabled = enabled;
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
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"{comboBoxDishesSearchBy.SelectedItem} LIKE '%{textBoxDishesSearch.Text}%'";
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

        private void buttonShowBasket_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    //  ClearSearchFiealds();
                    Guest_form.GuestTableLoader.LoadBasketTable(this.dataGridView1, basket);
                    ChangeEnabledOfDishesElements(false);
                    ChangeEnabledOfBasketElements(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
            }
        }

        private void ChangeEnabledOfBasketElements(bool enabled)
        {
            buttonMakePurchase.Enabled = buttonRemoveFromBasket.Enabled = enabled;
        }

        private void buttonAddToBasket_Click(object sender, EventArgs e)
        {
            if (!(dataGridView1.SelectedRows is null))
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    long id = long.Parse(item.Cells["Id"].Value.ToString());
                    string name = item.Cells["Название"].Value.ToString();
                    float cost = float.Parse(item.Cells["Цена"].Value.ToString());
                    string type = item.Cells["Тип"].Value.ToString();
                    string timeOfCooking = item.Cells["Время приготовления"].Value is null ? string.Empty : item.Cells["Время приготовления"].Value.ToString();
                    basket.Add(new Guest_form.basket(id, name, cost, type, timeOfCooking));
                }
            }
            else
            {
                MessageBox.Show("Не выбраны блюда", "No chosen dish", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonRemoveFromBasket_Click(object sender, EventArgs e)
        {
            if (!(dataGridView1.SelectedRows is null))
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    basket.RemoveAt(item.Index);
                }

                buttonShowBasket_Click(null, null);
            }
        }

        private void buttonMakePurchase_Click(object sender, EventArgs e)
        {
            Guest_form.ConfirmPurchaseForm confirmPurchaseForm = new Guest_form.ConfirmPurchaseForm(basket);
            if (basket.Count != 0)
            {
                if (confirmPurchaseForm.ShowDialog() == DialogResult.OK)
                {
                    foreach (var item in basket)
                    {
                        Guest_form.AddPurchaseInDB.InsertPurchaseIntoDB(item.id.ToString(), user.Id.ToString());
                    }

                    basket.Clear();
                    buttonShowBasket_Click(sender, e);
                    MessageBox.Show("Заказ оплачен!");
                }
            }
            else
            {
                MessageBox.Show("Корзина пуста!");
            }
        }
    }
}
