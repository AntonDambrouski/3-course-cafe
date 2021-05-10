using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.Guest_form
{
    public partial class ConfirmPurchaseForm : Form
    {
        List<basket> basket = null;
        public ConfirmPurchaseForm(List<basket> basket)
        {
            InitializeComponent();
            this.basket = basket;
        }

        private void buttonMakePurhcase_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ConfirmPurchaseForm_Load(object sender, EventArgs e)
        {
            loadTextBoxInfo();
        }

        private void loadTextBoxInfo()
        {
            textBoxChsnDishes.Clear();
            foreach (var item in basket)
            {
                textBoxChsnDishes.Text += $"id: {item.id}" + Environment.NewLine;
                textBoxChsnDishes.Text += $"Название: {item.nameOfDishes}" + Environment.NewLine;
                textBoxChsnDishes.Text += $"Цена: {item.cost}" + Environment.NewLine;
                textBoxChsnDishes.Text += $"Тип: {item.type}" + Environment.NewLine; 
                textBoxChsnDishes.Text += $"Время приготовления: {item.timeOfCooking}" + Environment.NewLine + Environment.NewLine;
            }
            textBoxChsnDishes.Text += Environment.NewLine;
            textBoxChsnDishes.Text += "Итого к оплате: " + GetAllCost();
        }

        private string GetAllCost()
        {
            float result = 0;
            foreach (var item in basket)
            {
                result += item.cost;
            }

            return result.ToString();
        }

        private void buttonSaveDishesTable_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Filter = "Текстовые файлы (*.txt)|*.txt"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = File.CreateText(saveFileDialog.FileName);
                    streamWriter.Write(textBoxChsnDishes.Text);
                    streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
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
                    Additional_buttons.SendTableOnEmail.SendEmail(textBoxChsnDishes.Text, inputEmail.textBoxEmail.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Send error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string pageBody = string.Empty;
        private void buttonPrintDishesTable_Click(object sender, EventArgs e)
        {
            pageBody = textBoxChsnDishes.Text;
            try
            {
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += PrintPageHandler;
                printPreviewDialog1.Document = doc;
                printPreviewDialog1.ShowDialog();
                printDialog1.Document = doc;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDialog1.Document.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            pageBody = string.Empty;
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e) // for printing handler
        {
            e.Graphics.DrawString(pageBody, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
    }
}
