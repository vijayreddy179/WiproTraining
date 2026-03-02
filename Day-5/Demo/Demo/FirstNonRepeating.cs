using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class FirstNonRepeating
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word :");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < s.Length; j++)
                {
                    if (i != j && s[i] == s[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine(s[i]);
                    return;
                }
            }
            Console.WriteLine("$");
        }
    }
}
