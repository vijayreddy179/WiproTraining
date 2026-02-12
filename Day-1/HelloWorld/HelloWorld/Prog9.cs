using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Prog9
    {
        static void Main()
        {
            int x = 10;
            int y = x++ + x++ + ++x + x++ + ++x;

            //Actual  10 + 11 + 13 + 13 + 15
            //Memory  11   12   13   14   15 
            Console.WriteLine(y);
        }
    }
}
