using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class savingaccount:AccountType
    {
        string type;
        public savingaccount(int id, string name, double amount, string type) : base(id, name, amount)
        { 
        Balance = amount;
        this.type = type;
        }

        public void withdraw(int amount)
        {
            
            if (Balance > 0 && Balance > amount)
            {
                Balance -= amount;
                Console.WriteLine("Money with drawn from saving account");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
            
        }




    }
}
