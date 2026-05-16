using abog.DBAccess;
using abog.Models;
using System;
using System.Data;

namespace abog.Services
{
    public class BookingService
    {
        private BookingAccess bookingAccess = new BookingAccess();

        // =========================
        // GET ALL BOOKINGS (ADMIN)
        // =========================
        public DataTable GetBookings()
        {
            Console.WriteLine("DEBUG - BookingService: GetBookings called");
            return bookingAccess.GetAllBookings();
        }

        // =========================
        // CREATE BOOKING (USER SIDE)
        // =========================
        public bool CreateBooking(Booking booking)
        {
            try
            {
                Console.WriteLine("DEBUG - BookingService: CreateBooking called");

                // 🔥 VALIDATION (VERY IMPORTANT)
                if (booking == null)
                {
                    Console.WriteLine("ERROR: Booking is null");
                    return false;
                }

                if (booking.UserId <= 0)
                {
                    Console.WriteLine("ERROR: Invalid UserId");
                    return false;
                }

                if (booking.ServiceId <= 0)
                {
                    Console.WriteLine("ERROR: Invalid ServiceId");
                    return false;
                }

                if (string.IsNullOrEmpty(booking.Address))
                {
                    Console.WriteLine("ERROR: Address is empty");
                    return false;
                }

                if (booking.StartDateTime >= booking.EndDateTime)
                {
                    Console.WriteLine("ERROR: Invalid date/time range");
                    return false;
                }

                // always force pending
                booking.Status = "pending";

                bool result = bookingAccess.CreateBooking(booking);

                Console.WriteLine("DEBUG - BookingService: Insert result = " + result);

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("SERVICE ERROR: " + ex.Message);
                throw;
            }
        }

        // =========================
        // UPDATE STATUS (ADMIN)
        // =========================
        public bool ApproveBooking(int bookingId)
        {
            return bookingAccess.UpdateBookingStatus(bookingId, "approved");
        }

        public bool RejectBooking(int bookingId)
        {
            return bookingAccess.UpdateBookingStatus(bookingId, "rejected");
        }

        public bool SetPending(int bookingId)
        {
            return bookingAccess.UpdateBookingStatus(bookingId, "pending");
        }

        // =========================
        // GET SINGLE BOOKING
        // =========================
        public Booking GetBookingById(int id)
        {
            return bookingAccess.GetBookingById(id);
        }

        // =========================
        // DELETE BOOKING
        // =========================
        public bool DeleteBooking(int id)
        {
            return bookingAccess.DeleteBooking(id);
        }
    }
}