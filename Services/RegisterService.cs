using Co_Mute.Models;

namespace Co_Mute.Services
{
    public class RegisterService
    {

        UsersDAO usersDAO = new UsersDAO();

        public RegisterService()
        {

        }

        public bool CreateUser(UserModel user)
        {
            return usersDAO.CreateUniqueUser(user);
        }
    }
}
