
using Entity.Models;

namespace Entity
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student ss = new Student() {FirstName="Amey",LastName="Loke",DateOfBirth=new DateTime(2001,1,5,0,0,0),Height=180,Weight=66,GradeId=1 };
            DbServices dbServices = new DbServices();
            
            /*dbServices.AddData(ss);*/
            dbServices.Display();
            dbServices.Delete(1);
            Console.WriteLine("______________After Deletion _________________");

            dbServices.Display();

            Console.WriteLine("________________Custom Query__________________");
            List<Student> students = dbServices.Customequery("Omkar");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("________________________JOIN________________________");
            dbServices.Liqdemo();

        }
    }
}
