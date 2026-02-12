using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Reverse
    {
        static void Main(string[] args)
        {
            string s = "Welcome to C# programming from Wipro Training";
            string[] str = s.Split(' ');
            for(int i=0;i<str.Length; i++)
            {
                if(i%2==1)
                {
                    char[] c = str[i].ToCharArray();
                    Array.Reverse(c);
                    str[i] = new string(c);
                }
            }
            Console.WriteLine(string.Join(" ", str));
        }
    }
}
