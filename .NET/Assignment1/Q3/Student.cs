using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dac
{
    public class student
    {
        public void add()
        {
            Console.WriteLine("Dac student is added");
        }
    }
}

namespace Dbda
{
    public class student
    {
        public void add()
        {
            Console.WriteLine("Dbda student is added");
        }
    }
}
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dac.student s1= new Dac.student();
            s1.add();
            Dbda.student s2=new Dbda.student();
            s2.add();

        }
    }
}
