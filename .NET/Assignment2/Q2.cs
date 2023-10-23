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
            string x=Console.ReadLine();
            float y=float.Parse(x);
            Console.WriteLine($"Result using Parse is: {y*y}");

            float z=Convert.ToSingle(x);
            Console.WriteLine($"Result using Convert is: {z * z}");

            float o;
            bool u=float.TryParse(x, out o);
            Console.WriteLine($"Result using TryParse  is: {o * o}");


        }
    }
}
