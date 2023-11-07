using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Grade
    {

        public int Id { get; set; }

        public string? GradeName { get; set; }

        public string? Section { get; set;}


        [ForeignKey("GradeId")]
        public IList<Student?> Students { get; set; } //navigation property one to many relationship formed
    }
}
