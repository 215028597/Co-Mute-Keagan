using Co_Mute.Models;
using System;
using System.Data.SqlClient;

namespace Co_Mute.Services
{
    public class UsersDAO
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"Co-Mute Database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool FindUserByNameAndPassword(UserModel user)
        {
            bool success = false;

            string sqlFind = "SELECT * FROM dbo.Users WHERE email = @email AND password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlFind, connection);

                command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar, 40).Value = user.Email;

                command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar, 40).Value = user.Password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return success;
        }

        public bool CreateUniqueUser(UserModel user)
        {
            string sqlStatement = "INSERT INTO dbo.Users VALUES (@Username,@Surname,@Phone,@Email,@Password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                bool success = false;
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                command.Parameters.Add("@Username", System.Data.SqlDbType.VarChar, 40).Value = user.Name;
                command.Parameters.Add("@Surname", System.Data.SqlDbType.VarChar, 40).Value = user.Surname;
                command.Parameters.Add("@Phone", System.Data.SqlDbType.VarChar, 15).Value = user.Phone;
                command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar, 40).Value = user.Email;
                command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar, 40).Value = user.Password;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    success = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return success;
            }

        }
    }
}
