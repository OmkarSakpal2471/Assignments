using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c1=new Class1();
            int result=c1.fact(4);
            Console.WriteLine(result);
        }
    }
}
