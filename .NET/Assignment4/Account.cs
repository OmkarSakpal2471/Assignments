using System;
using System.Security.Cryptography.X509Certificates;

public class AccountType
{
	int id;
	string name;
	double balance;
    static int getId;

    static AccountType()
    {
        Console.WriteLine("Bank of India");
    }
    public AccountType(int id, string name,double balance)
	{
        Name = name;
        this.id = id;
        balance = Balance;
}

    public void deposit(double d)
    {
        Console.WriteLine("Money Deposited Successfully");
        balance += d;
    }
    public string Name
    {
        get { return name; }
        protected set { name = value; }
    }

    public int Id
    {
        get { return id; }
    }

    public double Balance
    {
        protected set { balance = value; }
        get { return balance; }
    }

}


