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
            String[] str = {"hello","hi","go","bye"};

            var subset=from s in str where s.StartsWith("h") select s;

            Console.WriteLine("in LINQ");
            foreach (var item in subset)
            {
                Console.WriteLine(item);
                
            }


            var sub=str.Where(i=>i.StartsWith("h")).Select(i=>i);
            Console.WriteLine("in lambda");
            foreach (var item  in sub)
            {
                Console.WriteLine(item);
            }
        }
    }
}




