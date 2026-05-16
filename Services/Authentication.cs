using abog.DBAccess;
using abog.Models;

namespace abog.Service
{
    public class Authentication
    {
        private readonly UserAccess uAccess = new UserAccess();
        private readonly AdminAccess aAccess = new AdminAccess();

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


        public Admin aLogin(String emailAddress, String password)
        {
            Admin admin = aAccess.FindAdminbyEmail(emailAddress);

            if (admin == null)
            {
                return null;
            }

            if (admin.password != password)
            {
                return null;
            }

            return admin;
        }
    }
}
