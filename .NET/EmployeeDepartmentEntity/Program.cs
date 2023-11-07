using EmployeeEntity.Models;

namespace EmployeeEntity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbServices services = new DbServices();
            /*            Employee e= new Employee() {Name="Akshay",Salary=68000,DepartmentId=2 };
                        services.AddEmployee(e);*/
            List<Employee> list = services.Display(1);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("___________________DISPLAY ALL TABLE______________________________");
            services.DisplayAll();

            Console.WriteLine("__________________________DELETE PARTICULAR EMPLOYEE_______________");
            services.DeleteEmp(3);
            services.DisplayAll();

            Console.WriteLine("_________________________JOIN____________________");
            services.liqDem();

            Console.WriteLine("____________________SALARY___________________________");
            List<Employee> employees = services.DisplayCondition(80000);
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("______________________NAME_______________________");
            services.DisplayChar();

            Console.WriteLine("_____________________ADD DEPARTMENT___________________");
            Department d1 = new Department() { DeptName = "Operations" };
            services.AddDept(d1);
            Console.WriteLine("______________ADDED EMPLOYEE__________________");
            Employee e = new Employee() { Name = "Nikhil", Salary = 68000, DepartmentId = 5 };
            services.AddEmployee(e);
            services.DisplayAll();
        }
    }
}