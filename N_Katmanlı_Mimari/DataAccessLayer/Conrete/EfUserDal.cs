using Core.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concete;
using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Conrete
{
    public class EfUserDal : EFRepositoryDal<User , Context> , IUserDal
    {

    }
}
