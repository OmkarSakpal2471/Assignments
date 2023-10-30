using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    delegate int myDelegate(int x,int y);
    class myMath
    {
       public  int add(int x,int y)
        {
            return x+y;
        }


        public  int product(int x,int y)
        {
            return x * y;
        }

        public static void Main()
        {

            myMath m1= new myMath();
            myDelegate del = m1.add;
            int result=del(30,8);
            Console.WriteLine(result);
            del=m1.product;
            result=del(8,8);
            Console.WriteLine(result);




        }

    }

}
