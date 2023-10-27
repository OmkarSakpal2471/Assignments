namespace Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
           savingaccount s1=new savingaccount(1,"Omkar",50000,"Saving");
            s1.withdraw(45000);
            Console.WriteLine(s1.Balance);

            currentaccount c1=new currentaccount(1,"Om",5000,"Current");
            c1.withdraw(6000);
            Console.WriteLine(c1.Balance);




        }
    }
}
