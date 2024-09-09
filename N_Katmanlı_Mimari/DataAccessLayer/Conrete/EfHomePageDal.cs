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
    public class EfHomePageDal : EFRepositoryDal<HomePage , Context> , IHomePageDal
    {

    }
}
