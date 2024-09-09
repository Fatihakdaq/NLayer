using Core.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concete;
using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Conrete
{
    public class EfReservationUserDal : EFRepositoryDal<ReservationUser, Context>, IReservationUserDal    
    {

    }
}
