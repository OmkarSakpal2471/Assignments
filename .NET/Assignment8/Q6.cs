using System;
using System.Linq;



class ProductInfo
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int NumberInStock { get; set; }
    public override string ToString()
    {
        return string.Format("Name={0}, Description={1}, Number in Stock={2}",
        Name, Description, NumberInStock);
    }
}
class entry
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Fun with Query Expressions *****\n");
        // This array will be the basis of our testing...
        ProductInfo[] itemsInStock = new[]
         {
        new ProductInfo{ Name = "Mac's Coffee", Description = "Coffee with TEETH",
                                         NumberInStock = 24},
        new ProductInfo { Name = "Milk Maid Milk",Description = "Milk cow's love",
                                            NumberInStock = 100},
         new ProductInfo{ Name = "Pure Silk Tofu",  Description = "Bland as Possible",
                                            NumberInStock = 120},
        new ProductInfo{ Name = "Cruchy Pops",  Description = "Cheezy, peppery goodness",
                                        NumberInStock = 2},
       new ProductInfo{ Name = "RipOff Water",   Description = "From the tap to your wallet",
                                        NumberInStock = 100},
    new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!",
         NumberInStock = 73}
                                    };

        /*Q1.Display all product detail
Q2. Display all product name
Q3.All product part of data as anonymous object
Q4.Display all product Name , and Description where 
 NumberInStock=100 as anonymous object
Q5.Display all product name having letter ‘s’ in it’s name in
 ascending order
Q6. Display all product name having letter ‘s’ in it’s name in descending order
Q7.count all product who’s stock is < 100
Q9. show max min and average value of numerinstock.*/


        Console.WriteLine("Using LINQ");
        var subset =from item in itemsInStock select item;
        foreach (var i in subset)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Using Lambda");
        subset =itemsInStock.Select(i => i);
        foreach (var i in subset)
        {
            Console.WriteLine(i);
        }

        //Q2
        Console.WriteLine("Using LINQ");
        var s = from item in itemsInStock select item.Name;
        foreach (var i in s)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Using Lambda");
        s = itemsInStock.Select(i => i.Name);
        foreach (var i in s)
        {
            Console.WriteLine(i);
        }

        //Q3




    }
}
