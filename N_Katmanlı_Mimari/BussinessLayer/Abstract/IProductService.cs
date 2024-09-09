using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IProductService
	{
		List<Product> GetAll();
		void Add(Product product);
		void Update(Product product);
		void Delete(Product product);
        Product GetById(int id);

    }
}
