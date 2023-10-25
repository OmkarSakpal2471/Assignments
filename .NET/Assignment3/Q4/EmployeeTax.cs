using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace ConsoleApp5
{

    enum Dept
    {
        MKT,
        ADMIN,
        ADV
    }
    class Employee
    {
        string name;
        int id;
        static int getId;
        double salary;
        double netSalary;
        Dept dept;

        static float ROI = 0.7f;

        public Employee(string name,double salary, Dept dept)
        {
            id = ++getId;
            this.name = name;
            this.salary = salary;
            this.dept = dept;
        }

        public double paytax(double p) {
            netSalary = salary - salary * ROI;
            return netSalary;

        }


        public void display()
        {
            paytax(salary);
            Console.WriteLine(name +" "+ (int)netSalary+" "+dept);
        }


    }
}
