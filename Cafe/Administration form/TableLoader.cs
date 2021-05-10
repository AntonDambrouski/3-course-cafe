using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.Administration_form
{
    static class TableLoader
    {
        static SqlDataAdapter sqlDataAdapter = null;
        static DataTable dataTable = null;

        public static void LoadDishesTable(DataGridView dataGridView, out string []searchBy)
        {
            searchBy = new string[]{
                "Id",
                "Название",
                "Цена",
                "Тип"
            };

            LoadTable(dataGridView, "Dishes");
        }

        public static void LoadWorkersTable(DataGridView dataGridView, out string[] searchBy)
        {
            searchBy = new string[]{
                "Id",
                "ФИО",
                "Возраст",
                "Зарплата",
                "Должность"
            };

            LoadTable(dataGridView, "Workers");
        }

        public static void LoadAccountsTable(DataGridView dataGridView)
        {
            LoadTable(dataGridView, "Accounts");
        }

        public static void LoadSalesTable(DataGridView dataGridView)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cafeDB"].ConnectionString);
                sqlDataAdapter = new SqlDataAdapter(@"
select  Purschase.Id,
        Dishes.*,
        Purschase.id_client
From Purschase
Join Dishes on Dishes.Id = Purschase.id_dish", sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                dataGridView.Columns[0].HeaderText = "Id покупки";
                dataGridView.Columns[1].HeaderText = "Id продажи";
                dataGridView.Columns["id_client"].HeaderText = "Id клиента";
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
