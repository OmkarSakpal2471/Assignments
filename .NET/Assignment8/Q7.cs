using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    internal class Class1
    {

        static void Main()
        {
            string[] arr = { "Omkar", "Harry Potter", "Larson & Turbo", "Dragon Ball", "Rising" };


            //using rythm
            var subset=from i in arr where i.Contains(" ") orderby i select i;

            foreach (var item in subset)
            {
                Console.WriteLine(item);
            }


            //using lambda function
            var set=arr.Where(i => i.Contains(" "));
            foreach (var item in set) {

                Console.WriteLine(item);
            }
 
        }
    }
}
