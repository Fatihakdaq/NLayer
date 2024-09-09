using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Conrete
{
    public class ReservationUserManager : IReservationUserService
    {
        private readonly IReservationUserDal _reservationUserDal;

        public ReservationUserManager(IReservationUserDal reservationUserDal)
        {
            _reservationUserDal = reservationUserDal;   
        }

        public void Add(ReservationUser reservation)
        {
          _reservationUserDal.Add(reservation);
        }

        public void Delete(ReservationUser reservation)
        {
           _reservationUserDal.Delete(reservation); 
        }

        public List<ReservationUser> GetAll()
        {
            return _reservationUserDal.GetAll();
        }

        public ReservationUser GetById(int id)
        {
          return _reservationUserDal.GetById(id);
        }

        public void Update(ReservationUser reservation)
        {
            _reservationUserDal.Update(reservation);    
        }
    }
}
