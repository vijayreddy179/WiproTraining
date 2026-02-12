using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class PalindromeCount
    {
        static void Main()
        {
            string s = "liril is soap, malayalam is language and madam heading company";
            string[] str = s.Split(' ');
            int c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                string word = str[i];
                bool isPalindrome = true;
                int l = 0;
                int r = word.Length - 1;
                while(l<r)
                {
                    if (word[l] != word[r])
                    {
                        isPalindrome = false; break;
                    }
                    l++;
                    r--;
                }
                if (isPalindrome && word.Length > 1)
                {
                    c++;
                }
            }
            Console.WriteLine("Total Count of Palindrome Words : "+c);
        }
    }
}
