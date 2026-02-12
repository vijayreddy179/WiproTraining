using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class ConstructorEx
    {
        static ConstructorEx()
        {
            Console.WriteLine("Static Constructor...");
        }
        ConstructorEx()
        {
            Console.WriteLine("Instance Constructor...");
        }
        static void Main()
        {
            ConstructorEx c=new ConstructorEx();
        }
    }
}
