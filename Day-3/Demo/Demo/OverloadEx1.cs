using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class OverloadEx1
    {
        public int Sum()
        {
            return 10;
        }

        public int Sum(int x)
        {
            return x + 10;
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main()
        {
            OverloadEx1 o = new OverloadEx1();
            Console.WriteLine("Sum w.r.t. Zero Args " + o.Sum());
            Console.WriteLine("Sum w.r.t. One Arg   " + o.Sum(82));
            Console.WriteLine("Sum w.r.t. Two Args  " + o.Sum(81, 62));
        }
    }
}
