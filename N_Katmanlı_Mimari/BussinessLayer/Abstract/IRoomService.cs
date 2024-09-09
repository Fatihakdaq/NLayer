using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IRoomService
    {
        List<Room> GetAll();
        void Add(Room room);
        void Update(Room room);
        void Delete(Room room);
        Room GetById(int id);
    }
}
