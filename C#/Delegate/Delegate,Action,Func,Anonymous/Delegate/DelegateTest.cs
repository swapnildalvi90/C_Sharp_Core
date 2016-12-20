using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void DelegateToFunc(string message);
   
    class DelegateTest
    {
        static void Main(string[] args)
        {
            DelegateToFunc delfun = new DelegateToFunc(PrintMessage);
            delfun("Swapnil");
        }

        public static void PrintMessage(string message)
        {
            Console.Write("Hello " + message);
            Console.ReadKey();
        }
    }
}
//if function is static then its delegate's signature is not needed to be static.

