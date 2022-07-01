using Co_Mute.Models;
using Co_Mute.Services;
using Microsoft.AspNetCore.Mvc;

namespace Co_Mute.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ProcessLogin(UserModel usermodel)
        {
            SecurityService securityService = new SecurityService();

            if (securityService.isValid(usermodel))
            {
                return View("LoginSuccess", usermodel);
            }
            else
            {
                return View("LoginFailure", usermodel);
            }
        }
    }
}
