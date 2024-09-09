using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IHomePageService
    {
        List<HomePage> GetAll();
        void Add(HomePage homePage);
        void Update(HomePage homePage);
        void Delete(HomePage homePage);
        HomePage GetById(int id);

    }
}
