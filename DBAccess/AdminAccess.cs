using abog.Config;
using abog.Models;
using Microsoft.Data.SqlClient;


namespace abog.DBAccess
{
    public class AdminAccess
    {

        public Admin FindAdminbyEmail(string emailAddress)
        {
            string selectSql = "SELECT * FROM admin WHERE email_address = @email_address";

            using (var conn = new SqlConnection(DatabaseConfig.Connection))
            using (var cmd = new SqlCommand(selectSql, conn))
            {
                cmd.Parameters.AddWithValue("@email_address", emailAddress);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Admin
                        {
                            adminId = (int)reader["admin_id"],
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
