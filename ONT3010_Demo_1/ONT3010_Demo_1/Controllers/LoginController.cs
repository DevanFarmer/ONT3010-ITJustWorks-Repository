using Microsoft.AspNetCore.Mvc;
using ONT3010_Demo_1.Models;
using ONT3010_Demo_1.Data;

namespace ONT3010_Demo_1.Controllers
{
    public class LoginController : Controller
    {
        DB dB = new DB();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginCheck login)
        {
            int result = dB.Login_Check(login);
            if (result == 1)
            {
                TempData["msg"] = "Login Success";
            }
            else
            {
                TempData["msg"] = "Login Failed";
            }
            return View();
        }
        public IActionResult SuccessPage()
        {
            return View();
        }
    }
}
