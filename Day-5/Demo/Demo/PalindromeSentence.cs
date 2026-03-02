using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class PalindromeSentence
    {
        static void Main()
        {
            Console.WriteLine("Enter Sentence :");
            string s = Console.ReadLine();
            s = s.ToLower();
            string s1 = "";
            foreach(char c in s)
            {
                if(char.IsLetterOrDigit(c))
                {
                    s1 += c;
                }
            }
            int i = 0;
            int j = s1.Length - 1;
            while(i<j)
            {
                if (s1[i] != s1[j])
                {
                    Console.WriteLine("false");
                    return;
                }
                i++;
                j--;
            }
            Console.WriteLine("true");
        }
    }
}
