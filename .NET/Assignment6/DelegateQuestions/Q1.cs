using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    delegate int myMath(int x,int y);
    class Student
    {
       public static int add(int x,int y)
        {
            return x+y;
        }


        public static int product(int x,int y)
        {
            return x * y;
        }

        public static void Main()
        {
            myMath m = add;
            int Sum=m(10, 90);
            Console.WriteLine(Sum);
            m = product;
            int Product=m(2, 8);
            Console.WriteLine(Product);

        }

    }

}
