using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Employee
    {
        public System.Int16 empid;
        public string name;
        public List<Address> empAdd;

        public Address this[int addressId]
        {
            get { return empAdd.Where(add => add.addressid == addressId).First();}
        }

    }
}
