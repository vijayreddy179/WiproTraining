using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Demo
    {
        public void SayHello()
        {
            Console.WriteLine("Welcome to C# Programming...");
        }

        private void Trainer()
        {
            Console.WriteLine("Trainer is Mr. Prasanna Pappu...");
        }

        internal void Company()
        {
            Console.WriteLine("Company is Wipro...");
        }
    }
    internal class Prog11
    {
        static void Main()
        {
            Demo demo = new Demo();
            demo.SayHello();
            demo.Company();
            //demo.
        }
    }
}
