using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class ReduceString
    {
        static void Main()
        {
            Console.WriteLine("Enter word :");
            string s = Console.ReadLine();
            Console.WriteLine("Enter K Value :");
            int k = int.Parse(Console.ReadLine());
            string res = "";
            for(int i = 0; i < s.Length; i++)
            {
                int c = 1;
                while(i+1<s.Length && s[i] == s[i+1])
                {
                    c++;
                    i++;
                }
                if(c!=k)
                {
                    res += new string(s[i], c);
                }
            }
            Console.WriteLine(res);
        }
    }
}
