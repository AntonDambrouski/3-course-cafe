using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafe.Guest_form;
using System.Configuration;

namespace Cafe.Authorization
{
    static class AuthorizationController
    {

        public static void CheckInputFields(string login, string password)
        {
            if (login.Length == 0 || password.Length == 0)
            {
                throw new ArgumentException("Не все поля заполнены!");
            }

            if (password == "Введите пароль" || login == "Введите логин")
            {
                throw new ArgumentException("Не все поля заполнены!");
            }
        }

        public static User CheckInputDataReturnType(string login, string password)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cafeDB"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM Accounts WHERE Логин = N'{login}'", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlCommand.Dispose();
                if (sqlDataReader.Read())
                {
                    if (Convert.ToString(sqlDataReader[4]) == password)
                    {
                        return new User(long.Parse(sqlDataReader[0].ToString()), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetString(5));
                    }
                    else
                    {
                        throw new ArgumentException("Неверный пароль", "password");
                    }
                }
                else
                {
                    throw new ArgumentException("Неверный логин", "login");
                }
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

        private static string GetType(SqlDataReader sqlDataReader, string password)
        {
            try
            {
                if (sqlDataReader.Read())
                {
                    if (Convert.ToString(sqlDataReader[0]) == password)
                    {
                        string type = Convert.ToString(sqlDataReader[1]);
                        return type;
                    }
                    else
                    {
                        throw new ArgumentException("Неверный пароль", "password");
                    }
                }
                else
                {
                    throw new ArgumentException("Неверный логин", "login");
                }
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
                sqlDataReader.Close();
            }
        }

    }
}
