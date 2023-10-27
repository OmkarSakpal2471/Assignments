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


        public currentaccount(int id,string name,double amount,string type) : base(id,name,amount) {
            Balance = amount;
            this.type = type;
        }

        public void withdraw(int amount)
        {
                
                Balance-=amount;
            Console.WriteLine("Money withdrawn from current account");
            
        }
            }
}
