using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class RefEx1
    {
        public void Increment(ref int x)
        {
            x++;
        }
        static void Main()
        {
            RefEx1 refEx1 = new RefEx1();
            int x = 12;
            refEx1.Increment(ref x);
            Console.WriteLine(x);
        }
    }
}
