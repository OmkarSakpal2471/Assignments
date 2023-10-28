namespace Account
{
    internal class Program
    {


        static void Main(string[] args)
        {
            AccountType a1 = new currentaccount("Omkar", 50000, "current");
            a1.withdraw(7000);
            a1.deposit(7000);
            Console.WriteLine(a1);
            a1.withdraw(80000);
            Console.WriteLine(a1);

            AccountType a2 =new savingaccount("Om",70000,"saving");
            a2.withdraw(60000);
            Console.WriteLine(a2);
            a2.withdraw(10000);
            Console.WriteLine(a2);






        }
    }
}
