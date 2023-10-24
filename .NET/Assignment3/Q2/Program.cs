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
            Account a=new Account("Omkar");
            a.deposit(5000);
            a.withdraw(4000);
            a.withdraw(1500);
            a.display();

            Account b = new Account("Om");
            b.deposit(10000);
            b.display();
        }
    }
}
