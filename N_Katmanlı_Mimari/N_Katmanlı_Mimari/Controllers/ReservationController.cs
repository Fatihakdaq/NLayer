using BussinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Model.Reservation;
using Microsoft.AspNetCore.Mvc;

namespace N_Katmanlı_Mimari.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationUserService reservationUserService;

        public ReservationController(IReservationUserService reservationUserService)
        {
            this.reservationUserService = reservationUserService;
        }

        public ViewResult Index()
        {
           return View();
        }

        public ViewResult GetAll()
        {
            var result = reservationUserService.GetAll();
            return View(result);

        }

        // Add Reservation Page Get

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        // Add Reservation Page Post

        [HttpPost]
        public ActionResult Add(ReservationUser reservation)
        {
            // Tarih çakışması kontrolü
            var existingReservation = reservationUserService.GetAll()
                .FirstOrDefault(x => x.CheckInDate == reservation.CheckInDate && x.CheckOutDate == reservation.CheckOutDate);

            if (existingReservation != null)
            {
                return RedirectToAction("Eror", "Reservation"); // Çakışırsa buraya yönlendir
            }

            // Tarih çakışması yoksa, rezervasyonu ekle
            reservationUserService.Add(reservation);

            return RedirectToAction("GetAll", "Reservation");
        }

        // Eror Message Page Get 

        public IActionResult Eror() 
        { 
            return View(); 
        }

        // Delete Reservation Page Post

        [HttpPost]
        public IActionResult Delete(int id) 
        {
           var userDelete =  reservationUserService.GetById(id);
            if(userDelete!= null)
            {
                reservationUserService.Delete(userDelete);
                return Ok();
            }
            return NotFound();
        }

        // Edit Reservation Page Get

        [HttpGet]
        public IActionResult Edit(int id) 
        { 
     
                var reservationId = reservationUserService.GetById(id);

                if (reservationId == null) 
                { 
                   return NotFound();
                }

                var editView = new Edit 
                { 
                  Name = reservationId.Name,
                  SurName = reservationId.SurName,  
                  Gender = reservationId.Gender,    
                  TCKN = reservationId.TCKN,    
                  DateOfBirth = reservationId.DateOfBirth,  
                  CheckInDate = reservationId.CheckInDate,  
                  CheckOutDate = reservationId.CheckOutDate,    
                };

                return View(editView);  
      
        }

        // Edit Reservation Page Post
        [HttpPost]
        public IActionResult Edit(Edit edit)
        {
            var retryIdController = reservationUserService.GetById(edit.Id);

            if (retryIdController != null) 
            { 
                retryIdController.Name = edit.Name;   
                retryIdController.SurName = edit.SurName;
                retryIdController.Gender = edit.Gender;
                retryIdController.TCKN = edit.TCKN.ToString();
                retryIdController.DateOfBirth = edit.DateOfBirth;
                retryIdController.CheckInDate = edit.CheckInDate;
                retryIdController.CheckOutDate = edit.CheckOutDate;

                reservationUserService.Update(retryIdController);
                return RedirectToAction("GetAll", "Reservation");

            }
            return NotFound();
        }
    }
}
