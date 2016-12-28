using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityFrameworkCodeFirst
{
    public class CustomerDBContext : DbContext
    {
        public DbSet<Customer> Customers{get; set;}
        public DbSet<Order> Orders { get; set; }

    }
}