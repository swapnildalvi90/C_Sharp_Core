using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee
            {
                empid = 1,
                name = "swapnil",
                empAdd = new List<Address>{
                                           new Address{addressid=1,addressLine="dgfvgsdhf"},
                                           new Address{addressid=2,addressLine="jhgfbsfhs"}
                                           }
            };

            Address a = emp1[1];
            Console.WriteLine(a.addressid);
            Console.WriteLine(a.addressLine);
            Console.ReadKey();
        }
    }
}
