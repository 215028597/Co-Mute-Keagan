using Co_Mute.Models;

namespace Co_Mute.Services
{
    public class SecurityService
    {
        UsersDAO usersDAO = new UsersDAO(); 


        public SecurityService()
        {

        }

        public bool isValid(UserModel user)
        {
            return usersDAO.FindUserByNameAndPassword(user);

        }
    }
}
