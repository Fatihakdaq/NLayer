using BussinessLayer.Abstract;
using EntityLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Model.User;
using Microsoft.AspNetCore.Mvc;

namespace N_Katmanlı_Mimari.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult GetAll()
        {
            var result = userService.GettAll();
            return View(result);
        }

        [HttpGet]
        public ActionResult add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(User user)
        {
            userService.Add(user);


            return RedirectToAction("GetAll");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var user = userService.GetById(id);
            if (user != null)
            {
                userService.Delete(user);
                return Ok();
            }
            return NotFound();
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var userGet = userService.GetById(id);

            if (userGet == null)
            {
                return BadRequest();
            }

            Edit newEdit = new Edit
            {
                FullName = userGet.FullName,
                Email = userGet.Email,
            };

            return View(newEdit);
        }

        [HttpPost]
        public ActionResult Edit(Edit model)
        {
            var IdControl = userService.GetById(model.Id);

            if(IdControl != null)
            { 
                IdControl.FullName = model.FullName;
                IdControl.Email = model.Email;  

                userService.Update(IdControl);
                return RedirectToAction("GetAll", "User");
            }
            return BadRequest();
        }
    }
}
