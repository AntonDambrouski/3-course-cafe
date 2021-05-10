using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.Guest_form
{
    static class GuestTableLoader
    {
        static SqlDataAdapter sqlDataAdapter = null;
        static DataTable dataTable = null;

        public static void LoadDishesTable(DataGridView dataGridView, out string[] searchBy)
        {
            searchBy = new string[]{
                "Id",
                "Название",
                "Цена",
                "Тип"
            };

            LoadTable(dataGridView, "Dishes");
        }

        public static void LoadBasketTable(DataGridView dataGridView, List<Guest_form.basket> basket)
        {
            dataTable.Dispose();
            dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Название");
            dataTable.Columns.Add("Цена");
            dataTable.Columns.Add("Тип");
            dataTable.Columns.Add("Время приготовления");
            foreach (var item in basket)
            {
                dataTable.Rows.Add(item.id, item.nameOfDishes, item.cost,item.type, item.timeOfCooking);
            }

            dataGridView.DataSource = dataTable;
        }

        public static void SaveChanges()
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cafeDB"].ConnectionString);
                sqlDataAdapter.UpdateCommand = new SqlCommandBuilder(sqlDataAdapter).GetUpdateCommand();
                sqlDataAdapter.Update(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void LoadTable(DataGridView dataGridView, string table)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cafeDB"].ConnectionString);
                sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {table}", sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (!(sqlConnection is null))
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
