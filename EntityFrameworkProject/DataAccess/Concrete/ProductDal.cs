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
