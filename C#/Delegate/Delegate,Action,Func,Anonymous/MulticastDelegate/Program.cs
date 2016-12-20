/*
 when you want youe delegate to point more than one method(i.e. chain of method) at this time we use multicast delegate.
 therefore it is important that all your methods which we want to point to delegate should have same signature.
 
 
 *if your methods return something then your multicast delegate will return only last method's returned value 
 i.e. method which is last in a chain.
 
 * same is the case with out parameter
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    delegate void DelToShowMessage(string message);
    delegate int DelToReturnNumber();

    class Program
    {
        static void Main(string[] args)
        {
            DelToShowMessage del1 = new DelToShowMessage( ShowMessage);
            del1 += ShowSuccess;

            del1("Swapnil");

            DelToReturnNumber del2 = new DelToReturnNumber(MethReturnNumber1);
            del2+= MethReturnNumber2;

            int returnedValueFromDelegate = del2();
            Console.WriteLine("returned calue from delegate: "+returnedValueFromDelegate);
            Console.ReadKey();
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine("Showing message in console: " + message);
        }

        public static void ShowSuccess(string message)
        {
            Console.WriteLine(message+"We have displayed your message Successfully!!!");
            //Console.ReadKey();
        }


        public static int MethReturnNumber1()
        {
            return 1;
        }

        public static int MethReturnNumber2()
        {
            return 2;
        }


    }
}
