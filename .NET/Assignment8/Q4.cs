using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    class Employee
    {

        static void Main()
        {
            int[] a = { 5, 8, 9, 10, 7, 4, 3 };
            var subset=from i in a where i>=8 select i;

            Console.WriteLine("in LINQ");
            foreach (var item in subset)
            {
                Console.WriteLine(item);
                
            }

            var sub=a.Where((i)=>i>=8).Select(i=>i);

            Console.WriteLine("in lambda");
            foreach (var item in sub)
            {
                Console.WriteLine(item);
                
            }

        }


    }
}




