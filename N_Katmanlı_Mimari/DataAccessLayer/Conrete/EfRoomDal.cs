using Core.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Conrete
{
    public class EfRoomDal : EFRepositoryDal<Room , Context>, IRoomDal 
    {
        // Yani sen gel EFRepositoryDal üzerinden Croud işlemlerin interfacleri entgere et neye Room Entity sine ve Conetxt 
    }
}
