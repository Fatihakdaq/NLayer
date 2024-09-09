using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IUserService
    {
        List<User> GettAll();
        void Add(User user);    
        void Delete(User user);
       
        void Update(User user);
        User GetById(int id);

    }
}
