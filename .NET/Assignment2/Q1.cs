using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.WriteLine("Enter Two numbers");
            a = Console.ReadLine();
            b = Console.ReadLine();
            float x = float.Parse(a);
            float y = float.Parse(b);
            float result = x + y;
            Console.WriteLine("Result using parse is " + result);

            
            Console.WriteLine("Enter Two numbers");
/*            l=Console.ReadLine();
            m=Console.ReadLine();*/
            float xy=Convert.ToSingle(a);
            float z=Convert.ToSingle(b);
/*            int n=Convert.ToInt32(null);*/
            Console.WriteLine($"Result using Convert is:{xy+z}" );


            float r,o; 
            bool zz = float.TryParse(a, out r);
            bool cc=float.TryParse(b, out o);
            Console.WriteLine(zz);
            if (zz && cc)
            {
                Console.WriteLine($"Result using TryParse is:{r+o}");
            }
            else
                Console.WriteLine("Invalid data");






        }
    }
}
