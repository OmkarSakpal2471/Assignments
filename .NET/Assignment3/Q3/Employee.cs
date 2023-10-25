using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace ConsoleApp5
{
   class Employee
    {
        string name;
        int id;
        static int getId;
        double salary;
        double netSalary;

        public Employee(string name,double salary)
        {
            id =++getId;
            this.name = name;
            this.salary = salary;

        }

        public double Calculatesal()
        {
            netSalary = salary - salary * 0.1;
            return netSalary;
        }

        public void display()
        {
            Calculatesal();
            Console.WriteLine(name +" "+ netSalary);

        }


    }
}
