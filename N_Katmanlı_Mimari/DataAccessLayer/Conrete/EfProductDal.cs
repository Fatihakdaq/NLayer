using Core.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer.Conrete
{
    public class EfProductDal : EFRepositoryDal<Product, Context> , IProductDal
	{
     
    }
}
