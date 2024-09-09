using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BussinessLayer.Conrete
{
    public class HomePageManager : IHomePageService
    {
        private readonly IHomePageDal _homePageDal;
        public HomePageManager(IHomePageDal homePageDal)
        {
            _homePageDal = homePageDal;
        }

        public void Add(HomePage homePage)
        {
            _homePageDal.Add(homePage);
        }

        public void Delete(HomePage homePage)
        {
            _homePageDal.Delete(homePage);
        }

        public List<HomePage> GetAll()
        {
            return _homePageDal.GetAll();
        }

        public HomePage GetById(int id)
        {
            return _homePageDal.GetById(id);
        }

        public void Update(HomePage homePage)
        {
            _homePageDal.Update(homePage);
        }
    }
}
