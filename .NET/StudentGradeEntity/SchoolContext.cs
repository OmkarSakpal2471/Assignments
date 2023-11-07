using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entity.Models
{
    public class SchoolContext:DbContext//dbcontext class db mei dalega it has method add delete update
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=customer;Integrated Security=True;");
        }

        public DbSet<Student> Student {  get; set; }  //Dbset is entity which is represented as collection of student

        public DbSet<Grade> Grade { get; set; }
    }
}
