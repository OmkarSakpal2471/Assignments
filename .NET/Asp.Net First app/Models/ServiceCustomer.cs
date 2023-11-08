namespace CustomerWeb.Models
{
	public class ServiceCustomer:Icustomer
	{

		private static List<Customer> list;


		public ServiceCustomer()
		{
			list = new List<Customer>() {
			new Customer(){Id=1,Name="Omkar",Mobile="9920465918",Bill_amount=556.09f },
			new Customer(){Id=2,Name="Vedant",Mobile="8333905432",Bill_amount=778.90f },
			new Customer(){Id=3,Name="Nikhil",Mobile="8963707653",Bill_amount=898.98f } 
			};
		}
		

		public IEnumerable<Customer> GetAllCustomer()
		{
			return list;
		}


	}
}
