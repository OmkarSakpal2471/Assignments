using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class currentaccount:AccountType
    {


        string type;


        public currentaccount(string name,double amount,string type) : base(name,amount) {
            /*Balance = amount;*/
            this.type = type;
        }

        public override double  withdraw(double amount)
        {
                
            Balance-=amount;
            Console.WriteLine("Money withdrawn from current account");
            return Balance;
            
        }
            }
}
