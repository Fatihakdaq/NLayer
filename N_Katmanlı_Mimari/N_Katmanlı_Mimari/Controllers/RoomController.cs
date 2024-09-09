using BussinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Model.Reservation;
using EntityLayer.Model.Room;
using Microsoft.AspNetCore.Mvc;


namespace N_Katmanlı_Mimari.Controllers
{
    public class RoomController : Controller
    {

		private readonly IRoomService roomService;
        public RoomController(IRoomService roomService)
        {
            this.roomService = roomService;
        }
        public ViewResult Index()
		{
			return View();
		}
        [HttpGet]
		public ViewResult GetAll()
		{
			var result = roomService.GetAll();
			return View(result);
		}
		[HttpGet]
        public IActionResult Add() 
        {
            return View();
        }
        [HttpPost]

        public IActionResult Add(Room room) 
        {
            roomService.Add(room);
            return RedirectToAction("GetAll", "Room");
        }

        [HttpGet]
        public ActionResult Edit(int id) 
        { 
          var IdState = roomService.GetById(id);

            if (IdState != null) 
            {
                EditOne edit = new EditOne
                {
                    RoomId = IdState.RoomId,
                  RoomNumber = IdState.RoomNumber,  
                  RoomType = IdState.RoomType,  
                  Stock = IdState.Stock,    
                  IsActive = IdState.IsActive  
                };
                return View(edit);
            
            }
            return NotFound();  
        }

        [HttpPost]

        public IActionResult Edit(EditOne edit) 
        {
            var IdState = roomService.GetById(edit.RoomId);

            if (IdState != null) 
            {
                IdState.RoomNumber = edit.RoomNumber;
                IdState.RoomType = edit.RoomType;
                IdState.Stock = edit.Stock;
                IdState.IsActive = edit.IsActive;

                roomService.Update(IdState);
                return RedirectToAction("GetAll", "Room");
            }
            return NotFound();
        }

        [HttpPost]

        public ActionResult Delete(Room room) 
        {
            var IdState = roomService.GetById(room.RoomId);

            if(IdState != null)
            {
                roomService.Delete(IdState);
                return RedirectToAction("GetAll", "Room");
            }

            return NotFound();
        }

	}
}
