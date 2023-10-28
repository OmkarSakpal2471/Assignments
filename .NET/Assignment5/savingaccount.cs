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
        public savingaccount(string name, double amount, string type) : base( name, amount)
        { 
        Balance = amount;
        this.type = type;
        }

        public override double withdraw(double amount)
        {
            
            if (Balance > 0 && Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine("Money with drawn from saving account");
                return Balance;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
                return Balance;
                
            }
            
        }

        public override string ToString()
        {
            return $"{Balance} {Id} {Name} {type}";
        }




    }
}
