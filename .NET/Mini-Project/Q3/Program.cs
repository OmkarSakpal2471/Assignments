using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Disconnected
{
    internal class Program
    {

        static void Main(string[] args)
        {
            EmployeeImplmt empimp= new EmployeeImplmt();
            empimp.Add(new Employee { Name = "Aditi", Address = "Chembur", Gender = Gend.Female });
            Console.WriteLine("____________________________Employee Added___________________________");

            Employee e=empimp.GetEmployee(1);
            Console.WriteLine(e);
            Console.WriteLine("_________________________Employee Deleted______________________________");
            empimp.Delete(2);

            Console.WriteLine("___________________________Get all Employee____________________________");
            var list=empimp.GetAllEmployee();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
        }
        
    }
}
