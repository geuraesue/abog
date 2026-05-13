using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        public Users() { }
    }

}
