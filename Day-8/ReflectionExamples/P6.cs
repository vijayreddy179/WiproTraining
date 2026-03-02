using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

[assembly: CLSCompliant(true)]
namespace ReflectionExamples
{

    public class P6
    {
        public void HelloWorld()
        {
        }
        //error because methods differ only in their case
        public void HELLOWORLD()
        {
        }

        static void Main()
        {

            Console.WriteLine("Welcome to Reflection...");
        }
    }
}