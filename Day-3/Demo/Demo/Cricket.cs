using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Cricket
    {
        static int score;
        public void Increment(int x)
        {
            score += x;
        }
        static void Main()
        {
            Cricket p1=new Cricket();
            Cricket p2=new Cricket();
            Cricket Ext=new Cricket();

            p1.Increment(21);
            p2.Increment(21);
            Ext.Increment(2);

            Console.WriteLine($"Total Score = {score}");
        }
    }
}
