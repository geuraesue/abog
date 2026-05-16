using abog.Config;
using abog.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace abog.DBAccess
{
    public class BookingAccess
    {
        // 🔥 GET ALL BOOKINGS (ADMIN TABLE)
        public DataTable GetAllBookings()
        {
            string query = @"
                SELECT 
                    b.booking_id,
                    u.first_name,
                    u.last_name,
                    s.service_name,
                    b.address,
                    b.start_datetime,
                    b.end_datetime,
                    b.status,
                    b.created_at
                FROM Booking b
                INNER JOIN Users u ON b.user_id = u.user_id
                INNER JOIN Services s ON b.service_id = s.service_id
                ORDER BY b.created_at DESC";

            using (var conn = new SqlConnection(DatabaseConfig.Connection))
            using (var cmd = new SqlCommand(query, conn))
            {
                Console.WriteLine("DEBUG - Loading all bookings...");

                using (var adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    Console.WriteLine("DEBUG - Bookings loaded: " + dt.Rows.Count);

                    return dt;
                }
            }
        }

        // 🔥 GET BOOKING BY ID
        public Booking GetBookingById(int bookingId)
        {
            string query = @"
                SELECT * 
                FROM Booking 
                WHERE booking_id = @booking_id";

            using (var conn = new SqlConnection(DatabaseConfig.Connection))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@booking_id", bookingId);

                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine("DEBUG - Booking found: " + bookingId);

                        return new Booking
                        {
                            BookingId = (int)reader["booking_id"],
                            UserId = (int)reader["user_id"],
                            ServiceId = (int)reader["service_id"],
                            Address = reader["address"].ToString(),
                            StartDateTime = (DateTime)reader["start_datetime"],
                            EndDateTime = (DateTime)reader["end_datetime"],
                            Status = reader["status"].ToString(),
                            CreatedAt = (DateTime)reader["created_at"]
                        };
                    }
                }
            }

            Console.WriteLine("DEBUG - Booking NOT found: " + bookingId);
            return null;
        }

        // 🔥 UPDATE STATUS (APPROVE / REJECT / PENDING)
        public bool UpdateBookingStatus(int bookingId, string status)
        {
            try
            {
                Console.WriteLine($"DEBUG - Updating booking {bookingId} to {status}");

                string query = @"
                    UPDATE Booking 
                    SET status = @status 
                    WHERE booking_id = @booking_id";

                using (var conn = new SqlConnection(DatabaseConfig.Connection))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@booking_id", bookingId);

                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    Console.WriteLine("DEBUG - Rows updated: " + rows);

                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                throw;
            }
        }

        // 🔥 OPTIONAL: DELETE BOOKING
        public bool DeleteBooking(int bookingId)
        {
            try
            {
                Console.WriteLine("DEBUG - Deleting booking: " + bookingId);

                string query = @"
                    DELETE FROM Booking 
                    WHERE booking_id = @booking_id";

                using (var conn = new SqlConnection(DatabaseConfig.Connection))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@booking_id", bookingId);

                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    Console.WriteLine("DEBUG - Rows deleted: " + rows);

                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                throw;
            }
        }

        // 🔥 CREATE BOOKING
        public bool CreateBooking(Booking booking)
        {
            try
            {
                Console.WriteLine("DEBUG - Creating booking...");

                string query = @"
                    INSERT INTO Booking
                    (user_id, service_id, address, start_datetime, end_datetime, status, created_at)
                    VALUES
                    (@user_id, @service_id, @address, @start_datetime, @end_datetime, @status, GETDATE())";

                using (var conn = new SqlConnection(DatabaseConfig.Connection))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", booking.UserId);
                    cmd.Parameters.AddWithValue("@service_id", booking.ServiceId);
                    cmd.Parameters.AddWithValue("@address", booking.Address);
                    cmd.Parameters.AddWithValue("@start_datetime", booking.StartDateTime);
                    cmd.Parameters.AddWithValue("@end_datetime", booking.EndDateTime);
                    cmd.Parameters.AddWithValue("@status", booking.Status);

                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    Console.WriteLine("DEBUG - Booking created rows: " + rows);

                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                throw;
            }
        }
    }
}