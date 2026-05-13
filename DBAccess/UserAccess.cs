using abog.Config;
using abog.Models;
using Microsoft.Data.SqlClient;


namespace abog.DBAccess
{
    public class UserAccess
    {
        public void addUser(Users user)
        {
            string sqlInsert = @"INSERT INTO Users (firstName, LastName, emailAddress, password, phoneNumber) 
                            VALUES (@firstName, @LastName, @emailAddress, @password, @phoneNumber)";


            using (var conn = new SqlConnection(DatabaseConfig.Connection))
            using (var cmd = new SqlCommand(sqlInsert, conn))
            {
                cmd.Parameters.AddWithValue("@firstName", user.firstName);
                cmd.Parameters.AddWithValue("@lastName", user.firstName);
                cmd.Parameters.AddWithValue("@emailAddress", user.firstName);
                cmd.Parameters.AddWithValue("@password", user.firstName);
                cmd.Parameters.AddWithValue("@phoneNumber", user.firstName);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }


        public Users FindUserbyEmail(string emailAddress)
        {
            string selectSql = "SELECT * FROM Users WHERE emailAddress = @emailAddress";

            using (var conn = new SqlConnection(DatabaseConfig.Connection))
            using (var cmd = new SqlCommand(selectSql, conn))
            {
                cmd.Parameters.AddWithValue("@emailAddress", emailAddress);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Users
                        {
                            UserId = (int)reader["UserID"],
                            firstName = reader["firstName"].ToString(),
                            lastName = reader["lastName"].ToString(),
                            emailAddress = reader["emailAddress"].ToString(),
                            password = reader["password"].ToString(),
                            phoneNumber = reader["phoneNumber"].ToString()

                        };
                    }
                }
            }
            return null;
        }
    }
}
