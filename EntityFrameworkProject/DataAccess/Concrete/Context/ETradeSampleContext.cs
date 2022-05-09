using EntityFrameworkProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.DataAccess.Concrete.Context
{
    public class ETradeSampleContext : DbContext
    {

        public DbSet<Product> Products { get; set; }



    }
}
