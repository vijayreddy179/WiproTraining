using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class RefEx2
    {
        public void Calc(int x, ref int f)
        {
            for (int i = 1; i <= x; i++)
            {
                f = f * i;
            }
        }
        static void Main()
        {
            int x = 6;
            int f = 1;
            RefEx2 refEx2 = new RefEx2();
            refEx2.Calc(x, ref f);
            Console.WriteLine($"Factorial Value  {f}");
        }
    }
}
