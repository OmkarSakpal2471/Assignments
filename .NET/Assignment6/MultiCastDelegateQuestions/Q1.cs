using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    delegate int myDelegate(int x);
    class myMath
    {
       public  int cube(int x)
        {
            return x*x*x;
        }


        public  int sqr(int x)
        {
            return x * x;
        }

        public static void Main()
        {

            myMath m1= new myMath();
            myDelegate del = m1.sqr;
            del += m1.cube;
            int result = del(7);

            foreach (myDelegate m in del.GetInvocationList())
            {
                Console.WriteLine(m.Method+"  "+m.Invoke(3));
            }
            





        }

    }

}
