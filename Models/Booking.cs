namespace abog.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public string Address { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        
        public Booking() { }

       
    }
}