using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Disconnected
{
    internal interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployee();

        Employee Add(Employee employee);

        Employee Update(Employee employee);

        Employee Delete(int id);
    }
}
