using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //context: db tabloları ile proje classlarını bağlamak için kullanılır.
    //Northwind ismi yerine ilerde kullanacagın database ismini yaz
    public class NorthwindContext:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // sql server bağlanacığımı belirtiyorum
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }


        //hangı nesnem hangı nesneye karşılık geldiğini gösteriyoruz
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
