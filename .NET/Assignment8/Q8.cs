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


        /*        Console.WriteLine("Using LINQ");
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
                }*//*

        //Q3
        *//*        var s1 = from item in itemsInStock select new {name=item.Name ,desc=item.Description,num=item.NumberInStock  };
                foreach (var item in s1)
                {
                    Console.WriteLine(item);
                }


                Console.WriteLine("Using lambda");
                s1=itemsInStock.Select(i=>new {name=i.Name ,desc=i.Description,num=i.NumberInStock});
                foreach (var item in s1)
                {
                    Console.WriteLine(item);
                }*//*


        //Q4
        *//*        var s3=from i in itemsInStock where i.NumberInStock==100 select new {name=i.Name,desc=i.Description };
                foreach (var item in s3)
                {
                    Console.WriteLine(item);
                }


                Console.WriteLine("uing lambda");
                s3 = itemsInStock.Where(r => r.NumberInStock == 100).Select(r=>new { name = r.Name, desc = r.Description });
                foreach (var item in s3)
                {
                    Console.WriteLine(item);
                }*//*


        //Q5
        *//*        var s4=from i in itemsInStock where i.Name.Contains("s") orderby i.Name select i;
                foreach (var item in s4)
                {
                    Console.WriteLine(item);

                }

                Console.WriteLine("using lambda function");
                var s5=itemsInStock.Where(r=>r.Name.Contains("s")).OrderBy(r=>r.Name).Select(r=>r);
                foreach (var item in s5)
                {
                    Console.WriteLine(item);
                }*//*

        //Q6
        *//*        var s4 = from i in itemsInStock where i.Name.Contains("s") orderby i.Name descending select i;
                foreach (var item in s4)
                {
                    Console.WriteLine(item);

                }

                Console.WriteLine("Using Lambda");
                var s5=itemsInStock.Where(i => i.Name.Contains("s")).OrderByDescending(i => i.Name).Select(i=>i);
                foreach (var  item  in s5)
                {
                    Console.WriteLine(item);
                }*/

        //Q7
/*        var s5 = (from i in itemsInStock where i.NumberInStock < 100 select i).Count();
        Console.WriteLine(s5);


        Console.WriteLine("Using lambda");
        var s6 = itemsInStock.Where(r => r.NumberInStock < 100).Select(i => i).Count();
        Console.WriteLine(s6);*/

        var s6 = (from i in itemsInStock select i.NumberInStock).Max();
        Console.WriteLine(s6);

        s6= (from i in itemsInStock select i.NumberInStock).Min();
        Console.WriteLine(s6);

        var r = (from i in itemsInStock select i.NumberInStock).Average();
        Console.WriteLine(r);


        Console.WriteLine("Using Lambda");
        s6 =itemsInStock.Select(i=>i.NumberInStock).Max();
        Console.WriteLine(s6);
        s6= itemsInStock.Select(i => i.NumberInStock).Min();
        Console.WriteLine(s6);


        r= itemsInStock.Select(i => i.NumberInStock).Average();
        Console.WriteLine(r);

        
    }
}
