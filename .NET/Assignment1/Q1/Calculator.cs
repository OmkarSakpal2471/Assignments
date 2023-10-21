using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Calculator
    {
        int Add(int x,int y)
        {
            return x + y;
        }

        int Product(int x,int y)
        {
            return x*y;
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int r=calculator.Add(1, 2);
            int s=calculator.Product(2, 3);
            Console.WriteLine($"Product="+s);
            Console.WriteLine($"Addition=" + r);
            Console.ReadLine();

        }
    }
}
