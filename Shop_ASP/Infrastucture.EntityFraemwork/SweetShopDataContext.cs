using Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.EntityFraemwork
{
    public class SweetShopDataContext: DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public SweetShopDataContext(): base("name=SweetShopConnectionString")
        {

        }

        public void Test()
        {
            Order order = new Order();
        }
    }
}
