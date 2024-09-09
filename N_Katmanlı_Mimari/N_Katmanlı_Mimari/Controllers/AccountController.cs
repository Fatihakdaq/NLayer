using BussinessLayer.Abstract;
using EntityLayer.Model.Login;
using Microsoft.AspNetCore.Mvc;

namespace N_Katmanlı_Mimari.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            var result = _userService.GettAll().FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);

            if (result == null) 
            {
                return RedirectToAction("Login", "Account");
            }

            return RedirectToAction("GetAll", "Reservation");

        }
    }
}
