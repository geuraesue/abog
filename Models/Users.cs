namespace abog.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }


        public Users(string firstName, string LastName, string emailAddress, string password, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = LastName; 
            this.emailAddress = emailAddress;
            this.password = password;
            this.phoneNumber = phoneNumber;
        }

        public Users() { }
    }

}
