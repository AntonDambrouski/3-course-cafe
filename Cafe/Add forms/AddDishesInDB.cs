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
    static class AddDishesInDB
    {
        public static void CheckOnCorrectInput(string productName, string price, string type, string timeOfCooking)
        {
            if (productName.Length == 0 || price.Length == 0 || type.Length == 0)
            {
                throw new ArgumentException("Не все поля заполнены!");
            }

            if (!float.TryParse(price, out float v))
            {
                throw new Exception("Некорректный формат данных!");
            }
        }

        public static void InsertProductIntoDB(string productName, string price, string type, string timeOfCooking)
        {
            SqlConnection sqlConnection = null;
            try
            {
                string insertCommand = timeOfCooking is null ? "Insert Into Dishes(Название, Цена, Тип, [Время приготовления])" +
                       " " + $"Values(@Название, @Цена, @Тип, null)" : "Insert Into Dishes(Название, Цена, Тип, [Время приготовления])" +
                       " " + $"Values(@Название, @Цена, @Тип, @Время_приготовления)";
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cafeDB"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand(insertCommand, sqlConnection);
                sqlCommand.Parameters.Add("@Название", SqlDbType.NVarChar).Value = productName;
                sqlCommand.Parameters.Add("@Цена", SqlDbType.Float).Value = price;
                sqlCommand.Parameters.Add("@Тип", SqlDbType.NVarChar).Value = type;
                if (!(timeOfCooking is null))
                {
                    sqlCommand.Parameters.Add("@Время_приготовления", SqlDbType.NVarChar).Value = timeOfCooking;
                }
               
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
