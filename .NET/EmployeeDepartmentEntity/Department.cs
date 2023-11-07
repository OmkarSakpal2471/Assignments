using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeEntity.Models
{
    public class Department
    {
        public int? Id { get; set; }

        public string? DeptName { get; set; }

        [ForeignKey("DepartmentId")]

        public IList<Employee> Employee { get; set;}

    }
}
