using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo.Solid
{
    class OnlineReport : IReadable
    {
        public void Read()
        {
            Console.WriteLine("Reading online report");
        }
    }
}
