using Co_Mute.Models;
using Co_Mute.Services;
using Microsoft.AspNetCore.Mvc;

namespace Co_Mute.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

 
      public IActionResult RegisterUser(UserModel usermodel)
        {
            RegisterService registerService = new RegisterService();

            if(registerService.CreateUser(usermodel))
            {
                return View("AccountCreated", usermodel);
            }
            else
            {
                return View("AccountNotCreated");
            }    
        }
    }
}
