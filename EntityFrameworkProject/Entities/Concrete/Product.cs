using EntityFrameworkProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Entities.Concrete
{
    public class Product : IEntity
    {

        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public int ProductStockAmount { get; set; }



    }
}
