using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;


namespace BussinessLayer.Conrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;
        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal; 
        }
        public void Add(Room room)
        {
           _roomDal.Add(room);  
        }

        public void Delete(Room room)
        {
            _roomDal.Delete(room);  
        }

        public List<Room> GetAll()
        {
           return _roomDal.GetAll();
        }

        public Room GetById(int id)
        {
            return _roomDal.GetById(id);    
        }

        public void Update(Room room)
        {
            _roomDal.Update(room);
        }
    }
}
