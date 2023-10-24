using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
   class Account
    {
        string name;
        static int id;
        double balance;

        static Account()
        {
            Console.WriteLine("Welcome to Bank Of India");
        }

        public Account(string name)
        {
            id = ++id;
            this.name = name; 
            balance = 0;
        }

        public void deposit(int amnt)
        {
            if (amnt > 0)
            {
                balance += amnt;
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }

        public void withdraw(int amnt)
        {
            if(balance > amnt)
            {
                balance -= amnt;
            }
            else
            {
                Console.WriteLine("Insufficeient Balance");
            }
        }

        public void display()
        {
            Console.WriteLine($"Name:{name}  Balance:{balance} ID:{id}");
        }

    }
}
