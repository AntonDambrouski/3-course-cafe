using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Guest_form
{
    static class AddPurchaseInDB
    {
        public static void InsertPurchaseIntoDB(string productId, string clientId)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cafeDB"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand("Insert Into Purschase(id_dish, id_client, [Дата покупки])" +
                       " " + $"Values(@id_dish, @id_client, @Дата_покупки)", sqlConnection);
                sqlCommand.Parameters.Add("@id_dish", SqlDbType.BigInt).Value = productId;
                sqlCommand.Parameters.Add("@id_client", SqlDbType.BigInt).Value = clientId;
                sqlCommand.Parameters.Add("@Дата_покупки", SqlDbType.Date).Value = DateTime.Now.ToShortDateString();

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
