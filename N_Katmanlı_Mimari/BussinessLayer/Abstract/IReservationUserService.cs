using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IReservationUserService
    {
        List<ReservationUser> GetAll();
        void Add(ReservationUser reservation);
        void Update(ReservationUser reservation);
        void Delete(ReservationUser reservation);
        ReservationUser GetById(int id);
    }
}
