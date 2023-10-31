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
            Dictionary<char,int> map = new Dictionary<char,int>();
            char[] arr = s.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                try
                {
                    map.Add(arr[i], i);
                }
                catch { }
            }

            foreach (var item in map)
            {
                Console.WriteLine(item);
            }
        }
    }
}




