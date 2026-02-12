using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class LoopEx1
    {
        public void Show()
        {
            int i = 0;
            int count = 10;
            while (i < count)
            {
                Console.WriteLine("Welcome to .NET Training...");
                i++;
            }
        }
        static void Main()
        {
            LoopEx1 loopEx1 = new LoopEx1();
            loopEx1.Show();
        }
    }
}
