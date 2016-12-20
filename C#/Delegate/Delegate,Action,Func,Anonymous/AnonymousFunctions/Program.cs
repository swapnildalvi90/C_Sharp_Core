//Anonymous methods are used to instatiate delegate 
//it uses keyword delegate


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousFunctions
{
    delegate  void DelegateToAnonymousMethod(string message);
    
    class Program
    {
        static void Main(string[] args)
        {
            DelegateToAnonymousMethod printMessage = new DelegateToAnonymousMethod(delegate(string message)
            {
                Console.WriteLine("Hello " + message);
                //Console.ReadKey();
            });
            
            Action<string> ShowMessage = delegate(string message){
                Console.WriteLine("Hello "+ message);
            };

            Func<string, string> GetAndShowMessage = delegate(string message){
            return ("Hello "+ message);
            };

            printMessage("From delegate");
            ShowMessage("From Action");
            string result=GetAndShowMessage("From Func");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
