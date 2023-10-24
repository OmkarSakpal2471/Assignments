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
            Student s1 = new Student("Omkar", 88, 96, 75);
            Console.WriteLine(s1.getTotal());
            s1.display();
            
        }
    }
}
