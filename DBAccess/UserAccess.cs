using abog.Config;
using abog.Models;
using Microsoft.Data.SqlClient;
using System;

namespace abog.DBAccess
{
    public class UserAccess
    {
        // 🔥 CHECK IF USER EXISTS
        public bool UserExists(string email, string phone)
        {
            string query = @"
                SELECT COUNT(*) 
                FROM Users 
                WHERE email_address = @email OR phaone_number = @phone";

            using (var conn = new SqlConnection(DatabaseConfig.Connection))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                // 🔥 DEBUG
                Console.WriteLine("DEBUG - Existing user count: " + count);

                return count > 0;
            }
        }

        // 🔥 ADD USER
        public bool addUser(Users user)
        {
            try
            {
                Console.WriteLine("DEBUG - addUser called");

                // check duplicates first
                if (UserExists(user.emailAddress, user.phoneNumber))
                {
                    Console.WriteLine("DEBUG - Duplicate detected");
                    return false;
                }

                string sqlInsert = @"
                    INSERT INTO Users 
                    (first_name, last_name, email_address, password, phone_number) 
                    VALUES 
                    (@first_name, @last_name, @email_address, @password, @phone_number)";

                using (var conn = new SqlConnection(DatabaseConfig.Connection))
                using (var cmd = new SqlCommand(sqlInsert, conn))
                {
                    cmd.Parameters.AddWithValue("@first_name", user.firstName);
                    cmd.Parameters.AddWithValue("@last_name", user.lastName);
                    cmd.Parameters.AddWithValue("@email_address", user.emailAddress);
                    cmd.Parameters.AddWithValue("@password", user.password);
                    cmd.Parameters.AddWithValue("@phone_number", user.phoneNumber);

                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    Console.WriteLine("DEBUG - Rows inserted: " + rows);

                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                throw;
            }
        }

        // 🔥 FIXED FIND USER
        public Users FindUserbyEmail(string emailAddress)
        {
            string selectSql = @"
                SELECT * 
                FROM Users 
                WHERE email_address = @emailAddress";

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
                            UserId = (int)reader["user_id"],
                            firstName = reader["first_name"].ToString(),
                            lastName = reader["last_name"].ToString(),
                            emailAddress = reader["email_address"].ToString(),
                            password = reader["password"].ToString(),
                            phoneNumber = reader["phone_number"].ToString()
                        };
                    }
                }
            }

            return null;
        }
    }
}