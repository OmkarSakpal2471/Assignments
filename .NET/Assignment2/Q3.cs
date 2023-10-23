using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{

    class Calculator
    {
        public int square(int x)
        {
            return x * x;
        }

        public int cube(int x)
        {
            return x * x*x;
        }

        public int round(double d) {
            return (int)d;
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();   
            int r=calculator.square(10);
            Console.WriteLine($"result of square method is:{r}");
            int q=calculator.cube(7);
            Console.WriteLine($"result of cube method is:{q}");
            int o=calculator.round(89.789);
            Console.WriteLine($"result of round method is:{o}");



        }
    }
}
