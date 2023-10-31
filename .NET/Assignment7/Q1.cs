using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Vidyanidhi";
            HashSet<char> set = new HashSet<char>();
            char[] c= s.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                set.Add(c[i]);
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}




