using EntityFrameworkProject.DataAccess.Abstract;
using EntityFrameworkProject.DataAccess.Concrete.Context;
using EntityFrameworkProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.DataAccess.Concrete
{
    public class ProductDal : IProductDal
    {

       

        public List<Product> GetAll()
        {
            using (ETradeSampleContext context = new ETradeSampleContext())
            {

                return context.Products.ToList();

            }


        }

        public List<Product> GetByNameFilter(string value)
        {
            using (ETradeSampleContext context = new ETradeSampleContext())
            {

                return context.Products.Where(p => p.ProductName.ToLower().Contains(value)).ToList(); //küçük harfe çevirmeden de sıkıntısız çalışır ama çevirmek best practisedir.Çünkü direkt veri tabanına gönderdik sorguyu.Eğer kolaksiyona where ile link sorgusu verilseydi tolower çevrimi şart olacaktı.aksi halde büyük küçük harf duyarlılığı sonuçları etkileyecekti.

            }


        }

        public List<Product> GetByUnitPriceFilter(decimal price1, decimal price2)
        {
            using (ETradeSampleContext context=new ETradeSampleContext())
            {

                return context.Products.Where(p=>p.ProductUnitPrice>=price1 && p.ProductUnitPrice<=price2).ToList();

            }
        }

        public void Add(Product product)
        {

            using (ETradeSampleContext context=new ETradeSampleContext())
            {
                var addedEntity = context.Entry(product);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

                /*context.Products.Add(product);
                context.SaveChanges(); deseydik de işlem gerçekleşirdi.*/ 

            }


        }

        public void Update(Product product)
        {

            using (ETradeSampleContext context = new ETradeSampleContext())
            {

                var updatedEntity = context.Entry(product);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();


            }


        }

        public void Delete(Product product)  //Entity framework de nesnelerle iş görüyoruz.Bu yüzden Ado net gibi id yollamadık.
        {

            using (ETradeSampleContext context = new ETradeSampleContext())
            {

                var deletedEntity = context.Entry(product);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();


            }


        }

        
    }
}
