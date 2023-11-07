using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema; 
using System.Threading.Tasks;

namespace EmployeeEntity.Models
{
    public class Employee
    {

        public int ID { get; set; }
        public string? Name { get; set; }

        public float? Salary {  get; set; }


        [ForeignKey("DepartmentId")]
        public int? DepartmentId { get; set; }

        public Department? Department { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}",ID,Name,Salary);
        }





    }
}
