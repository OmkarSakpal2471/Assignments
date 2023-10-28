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
    public AccountType( string name,double balance)
	{
        Name = name;
        id = ++getId;
        Balance = balance;
}

    public void deposit(double d)
    {
        Console.WriteLine("Money Deposited Successfully");
        Balance += d;
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

    public virtual double withdraw(double d)
    {
        return 0;
    }
    public override string ToString()
    {
        return $"{Balance} {Id} {Name}";
    }
}


