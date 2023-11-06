using System.Net;
using System.Reflection;
using System.Xml.Linq;

namespace CA_Disconnected
{
    internal class EmployeeImplmt: IEmployeeRepository
    {

        private static List<Employee> employeesList;

        public EmployeeImplmt()
        {
            employeesList = new List<Employee>()
            {
                new Employee{ID=1, Name="Omkar",Salary=85000,Address="Lalbaug",Gender=Gend.Male},
                new Employee{ID=2,Name="Swapnil",Salary=76000,Address="Ganesh Galli",Gender=Gend.Male},
                new Employee{ID=3,Name="Shreyas",Salary=78000,Address="Parel",Gender=Gend.Male}
            };
        }


        public Employee Add(Employee employee)
        {
            employee.ID = employeesList.Max(x => x.ID)+1;
            employeesList.Add(employee);
            return employee;

        }

        public Employee Delete(int id)
        {
        Employee employee= employeesList.FirstOrDefault(e=>e.ID==id);
            if (employee!=null)
            {
                employeesList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return employeesList;
        }

        public Employee GetEmployee(int id)
        {
            return employeesList.FirstOrDefault(e => e.ID == id);
        }

        public Employee Update(Employee employee)
        {
            Employee emp = employeesList.FirstOrDefault(e => e.ID == employee.ID);
            if(emp != null)
            {
                emp.ID = employee.ID;
                emp.Address= employee.Address;
                emp.Name= employee.Name;
                emp.Gender= employee.Gender;
            }
            return emp;
        }


    }
}