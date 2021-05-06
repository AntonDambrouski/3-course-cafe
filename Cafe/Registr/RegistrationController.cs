using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.Registr
{
    static class RegistrationController
    {  
        public static void AddNewUser(string name, string surname, string login, string password, string type)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cafeDB"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand("Insert Into Accounts(Имя, Фамилия, Логин, Пароль, Тип)" +
                        " " + $"Values(@Имя, @Фамилия, @Логин, @Пароль, @Тип)", sqlConnection);
                sqlCommand.Parameters.Add("@Имя", SqlDbType.NVarChar, 30).Value = name;
                sqlCommand.Parameters.Add("@Фамилия", SqlDbType.NVarChar, 30).Value = surname;
                sqlCommand.Parameters.Add("@Логин", SqlDbType.NVarChar, 50).Value = login;
                sqlCommand.Parameters.Add("@Пароль", SqlDbType.NVarChar, 50).Value = password;
                sqlCommand.Parameters.Add("@Тип", SqlDbType.NVarChar, 3).Value = type;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
            catch (ArgumentException ex)
            {
                throw ex;
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
