using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CA_Disconnected
{
    internal class Employee
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }

        public string Address { get; set; }
        public Gend Gender { get; set; }

        public override string ToString()
        {
            return $"ID={ID} Address={Address} Name={Name} Gender={Gender}";
        }
    }

    enum Gend
    {
        Male,
        Female,
        Others

    }
}
