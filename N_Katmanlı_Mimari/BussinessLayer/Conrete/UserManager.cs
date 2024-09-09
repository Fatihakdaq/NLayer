using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Conrete;
using EntityLayer.Abstract;
using EntityLayer.Concrete;


namespace BussinessLayer.Conrete
{
    public class UserManager : IUserService
    {
        //DI
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);  
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public User GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public List<User> GettAll()
        {
            return _userDal.GetAll();  
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
