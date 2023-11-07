using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set;}

        public DateTime? DateOfBirth { get; set; }

        public string? Photo { get; set; }

        public float? Height { get; set; }
        public float? Weight { get; set; }

        public string? Email {  get; set; }

        public string? Address {  get; set; }

        [ForeignKey("Grade")]
        public int? GradeId { get; set; } //principal table name and Primary key GradeID foriegn key
        public Grade? Grade { get; set; }//no column if we want to access grade from student table

        public override string ToString()
        {
            return String.Format("{0} ,{1},{2},{3},{4},{5},{6},{7}",FirstName,LastName,DateOfBirth,Height,Weight,GradeId,Photo,Address);
        }
    }
}
