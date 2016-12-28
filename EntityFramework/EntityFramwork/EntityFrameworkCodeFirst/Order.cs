using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCodeFirst
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        ////as foreign key generated for customer is having unwanted name...so....
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]

        public Customer customer { get; set; }
        
    }
}