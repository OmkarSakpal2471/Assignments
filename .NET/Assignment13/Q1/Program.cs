using Microsoft.Extensions.Configuration;
using System.Net;

namespace CustomerADO
{
    internal class Program/*

No database-level extended properties were found or all existing extended properties are open in other windows

*/
    {
        private static IConfiguration iconfiguration;

        public static void GetAppSettings()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).
            AddJsonFile("AppSettings.json", optional: false, reloadOnChange: true);
            iconfiguration=builder.Build();
        }
        
        public static string giveString(string name,string address,long mobnum)
        {
            return $"('{name}', '{address}', {mobnum})";
        }

        public static void printProduct(string s)
        {
            ProductLayer obj=new ProductLayer(iconfiguration);
            obj.Products(s);
        }

        static void CustomerDisplay()
        {
            Customer customer = new Customer()
            {
                Name = "Swapnil",
                Address = "Ganesh galli",
                mob_num = "983303205"
            };

            Strongly_type str1 = new Strongly_type(iconfiguration);

            //Get all list
            List<Customer> myList = str1.GetAll();
            foreach (var obj in myList)
            {
                Console.WriteLine($"{obj.Id}\t{obj.Name}\t{obj.Address}\t{obj.mob_num}");
            }


            //Get customer using ID
            List<Customer> myList2 = str1.GetCustId(1);
            foreach (var obj in myList2)
            {
                Console.WriteLine($"{obj.Id}\t{obj.Name}\t{obj.Address}\t{obj.mob_num}");
            }

            //add the customer
            int r = str1.AddData(customer);
            Console.WriteLine(r);

            //Get customer using name and mobile number
            List<Customer> myList3 = str1.GetCustIdName("Kunal", "808080808");
            foreach (var obj in myList3)
            {
                Console.WriteLine($"{obj.Id}\t{obj.Name}\t{obj.Address}\t{obj.mob_num}");
            }

            //Delete user using 
            int no = str1.Del(1004);
            Console.WriteLine("deleted {0}",no);

            int no1 = str1.Update(2, "Sakpal");
            Console.WriteLine("updated {0}", no1);
        }

        static void Main(string[] args)
        {
            GetAppSettings();
            CustomerDisplay();


            

        }
    }
}
