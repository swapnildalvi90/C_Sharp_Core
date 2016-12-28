using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCodeFirst
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        
        public List<Order> Orders { get; set; }
    }
}