using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Add_forms
{
    static class AddWorkersInDB
    {
        public static void CheckOnCorrectInput(string FIO, string age, string salary, string position)
        {
            if (FIO.Length == 0 || salary.Length == 0 || age.Length == 0 || position.Length == 0)
            {
                throw new ArgumentException("Не все поля заполнены!");
            }

            if (!float.TryParse(salary, out float _salary) || !int.TryParse(age, out int _age))
            {
                throw new Exception("Некорректный формат данных!");
            }
            else if (_salary <= 0 || _age < 16)
            {
                throw new ArgumentException("Некорректный формат данных!");
            }
        }

        public static void InsertProductIntoDB(string FIO, string age, string salary, string position)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cafeDB"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand("Insert Into Workers(ФИО, Возраст, Зарплата, Должность)" +
                       " " + $"Values(@ФИО, @Возраст, @Зарплата, @Должность)", sqlConnection);
                sqlCommand.Parameters.Add("@ФИО", SqlDbType.NVarChar).Value = FIO;
                sqlCommand.Parameters.Add("@Возраст", SqlDbType.SmallInt).Value = age;
                sqlCommand.Parameters.Add("@Зарплата", SqlDbType.Float).Value = salary;
                sqlCommand.Parameters.Add("@Должность", SqlDbType.NVarChar).Value = position;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
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
