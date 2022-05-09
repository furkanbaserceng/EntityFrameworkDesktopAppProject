using EntityFrameworkProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.DataAccess.Abstract
{
    public interface IProductDal
    {
       
        List<Product> GetAll();
        List<Product> GetByNameFilter(string value);
        List<Product> GetByUnitPriceFilter(decimal price1,decimal price2);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

    }
}
