using abog.DBAccess;
using abog.Models;

namespace abog.Service
{
    public class Authentication
    {
        private readonly UserAccess uAccess = new UserAccess();

        public Users Login(String emailAddress, String password)
        {
            Users user = uAccess.FindUserbyEmail(emailAddress);

            if (user == null)
            {
                return null;
            }

            if (user.password != password)
            {
                return null;
            }

            return user;
        }
    }
}
