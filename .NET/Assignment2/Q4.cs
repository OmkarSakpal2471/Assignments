using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    class Student
    {
        int prn_no;
        int java;
        int CSharp;
        int HTML;
        int total;
        double percentage;

        public Student(int prn_no, int java, int CSharp, int HTML)
        {
            if (java <=100 && CSharp <=100 && HTML<=100) { 
            this.prn_no = prn_no;   
            this.java = java;
            this.CSharp = CSharp;
            this.HTML = HTML;
            total =get_total();
            }
            else
            {
                Console.WriteLine("Write valid data");
            }
            percentage =get_percentage();
        }

        public int get_total()
        {   if(total==0)
            total=java+CSharp+HTML;
            return total;
        }

        public double get_percentage()
        {   
            /*Console.WriteLine(total*100/300);*/
            if (percentage == 0)
                percentage = total * 100 / 300;

            return percentage;


        }
        public void display()
        {
            Console.WriteLine(prn_no+" "+total+" "+percentage);
        }


    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(53, 78, 89, 98);
            s1.display();
            Student s2 = new Student(67, 90, 89, 67);
            s2.display();






        }
    }
}
