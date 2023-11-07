using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class DbServices
    {
        private static readonly SchoolContext db=new SchoolContext();


        public void AddData(Student s)
        {
            db.Add<Student>(s);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Student s=db.Student.SingleOrDefault<Student>(s=>s.StudentId==id);//LINQ TO ENTITY
            if (s != null)
            {
                db.Remove<Student>(s);
                db.SaveChanges();
            }
        }
        public void Display()
        {
            foreach (var item in db.Student.ToList<Student>()) //LINQ TO ENTITY
            {
                Console.WriteLine(item);
            }
        }

        public List<Student> Customequery(string name) {
            FormattableString sql = $"SELECT * FROM Student WHERE FirstName={name}";
            var studentList=db.Student.FromSql(sql).ToList();
            return studentList;
        }

        public void Liqdemo()
        {
            var r = db.Student.Join(db.Grade, (sg) => sg.GradeId, (gg) => gg.Id, (s, g) => new {Name=s.FirstName,Gradename=g.GradeName});
            foreach (var item in r)
            {
                Console.WriteLine(item.Gradename+" "+ item.Name);
            }
        }
    }
}
