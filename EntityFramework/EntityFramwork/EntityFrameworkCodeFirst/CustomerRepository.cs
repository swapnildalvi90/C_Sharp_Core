using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeFirst
{
    public class CustomerRepository
    {
        public List<Customer> GetAllCustomers()
        {
            CustomerDBContext cdc = new CustomerDBContext();
            return cdc.Customers.Include("Orders").ToList();
        }
    }
}