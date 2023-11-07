using EmployeeEntity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEntity
{
    public class DbServices
    {

        private static readonly Context db=new Context();



        public void AddEmployee(Employee ee)
        {
            db.Add<Employee>(ee);
            db.SaveChanges();
        }

        public void AddDept(Department de)
        {
            db.Add<Department>(de);
            db.SaveChanges();
        }
        public List<Employee> Display(int id)
        {
            FormattableString sql = $"SELECT * FROM Employee WHERE DepartmentId={id}";
            var studentList=db.Employee.FromSql(sql).ToList();
            return studentList;

        }

        public void DisplayAll()
        {
            foreach (var item in db.Employee.ToList<Employee>())
            {
                Console.WriteLine(item);
            }
        }
        public void liqDem()
        {
            var r = db.Employee.Join(db.Department, (sg) => sg.DepartmentId, (gg) => gg.Id, (s, g) => new { MyDepartment = g.DeptName, MyName = s.Name });
            foreach (var item in r)
            {
                Console.WriteLine(item.MyDepartment +" "+ item.MyName);
            }
        }
        public void DeleteEmp(int id)
        {
            Employee e1=db.Employee.FirstOrDefault(s=>s.ID==id);
            if(e1 != null )
            {
                db.Employee.Remove(e1);
                db.SaveChanges();
            }
        }

        public List<Employee> DisplayCondition(int sal)
        {
            FormattableString sql = $"SELECT * FROM Employee WHERE SALARY>{sal}";
            var EmployeeList=db.Employee.FromSql (sql).ToList();
            return EmployeeList;
        }

        public void DisplayChar()
        {
            FormattableString sql=$"SELECT * FROM Employee WHERE Name LIKE 'S%'";
            var result=db.Employee.FromSql (sql).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

    }
}
