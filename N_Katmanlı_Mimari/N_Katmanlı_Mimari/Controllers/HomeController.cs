using BussinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace N_Katmanlı_Mimari.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomePageService homePageService;

        public HomeController(IHomePageService homePageService)
        {
            this.homePageService = homePageService;
        }

        public IActionResult Index()
        {
            //var homePage = homePageService.GetAll();
            ////var homePageList = homePage.FirstOrDefault
            //return View(homePage);
            return View();  
        }

        [HttpGet]

        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(HomePage homePage) 
        {
            homePageService.Add(homePage);
            return RedirectToAction("Index");
        }
    }
}
