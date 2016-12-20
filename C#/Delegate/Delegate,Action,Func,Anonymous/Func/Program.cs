//Func is a delegate which takes one or more arguments and returrns the value
//Func takes parameters same as methods PLUS ONE FOR OUT PARAMETER


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> sum = Add;
            int result = sum(1, 2);
            Console.WriteLine("Addition is: " + result);
            Console.ReadKey();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}
