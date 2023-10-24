using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    internal class Student
    {
        string name;
        int maths;
        int science;
        int eng;


        public Student(string name, int maths, int science, int eng)
        {
            this.name = name;
            this.maths = maths;
            this.science = science;
            this.eng = eng;
        }

        public int getTotal()
        {
            return maths + science + eng;
        }

        public void display()
        {
            int total = getTotal();
            Console.WriteLine($"Name:{name} total:{total}  ");
        }
    }
}
