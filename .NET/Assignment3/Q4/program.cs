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
            Employee s1=new Employee("Omkar",89000,Dept.ADMIN);
            s1.display();
            Employee s2 = new Employee("Om", 99000,Dept.MKT);
            s2.display();
            Employee s3 = new Employee("Sagar", 75000,Dept.ADV);
            s3.display();
        }
    }
}
