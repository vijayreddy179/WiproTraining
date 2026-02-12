using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class ArrayEx1
    {
        public void Show()
        {
            int[] a = new int[] { 12, 66, 31, 66, 23, 122 };
            //for(int i=0;i<a.Length;i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
            ArrayEx1 a = new ArrayEx1();
            a.Show();
        }
    }
}
