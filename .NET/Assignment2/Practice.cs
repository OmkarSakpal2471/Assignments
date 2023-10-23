using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{

    struct employee
    {
        public  int id;
        public  string name;
        public employee(int a,string ans)
        {
            id = a;
            name = ans;
        }

        public void Display()
        {
            Console.WriteLine(id+" "+name);

        }

        public static void greet()
        {
            Console.WriteLine("greeting");
        }

        public static int num(String a) { 
            int age=int.Parse(a);
            return age; 
                
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            string age1 = "21";
            string age = "20";
            employee.num(age1);
            employee.num(age);
            Console.WriteLine(age);
            Console.WriteLine(age1);
            employee e = new employee(); 
            employee e3;
            
            employee e4=new employee(44,"Omkar");
            e3=e4;
            e4.name = "Om";
            e4.id = 56;
            e.Display();
            e3.Display();
            e4.Display();
            employee.greet();

            
            

        }
    }
}
