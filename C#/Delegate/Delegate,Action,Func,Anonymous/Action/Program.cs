//Action is nothing but Delegate that takes one or more arguments but does not return any value 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> ShowMessage = PrintMessage;
            Action<string, int> ShowMessageNoOfTimes = PrintMessageNoOfTimes;
            
            ShowMessage("Swapnil");
            ShowMessageNoOfTimes("Sudhakar",2);
        }
        public static void PrintMessage(string message)
        {
            Console.WriteLine("Hello " + message);
            //Console.ReadKey();
        }
        public static void PrintMessageNoOfTimes(string message, int num)
        {
            int i=0;
            while (i < num)
            {
                Console.WriteLine("Hello " + message);
                i++;
            }
            Console.ReadKey();
        }
    }
}
