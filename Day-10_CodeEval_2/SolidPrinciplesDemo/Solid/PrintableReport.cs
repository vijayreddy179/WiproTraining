using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo.Solid
{
    class PrintableReport : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Printing report");
        }
    }
}
