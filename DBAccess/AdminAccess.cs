using abog.Config;
using abog.Models;
using Microsoft.Data.SqlClient;


namespace abog.DBAccess
{
    public class AdminAccess
    {

        public Admin FindAdminbyEmail(string emailAddress)
        {
            string selectSql = "SELECT * FROM admin WHERE emailAddress = @emailAddress";

            using (var conn = new SqlConnection(DatabaseConfig.Connection))
            using (var cmd = new SqlCommand(selectSql, conn))
            {
                cmd.Parameters.AddWithValue("@emailAddress", emailAddress);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Admin
                        {
                            adminId = (int)reader["AdminID"],
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
