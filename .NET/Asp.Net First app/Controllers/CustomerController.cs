using CustomerWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerWeb.Controllers
{
	public class CustomerController : Controller
	{
		Icustomer cust;
		public CustomerController(Icustomer cust) {
			this.cust = cust;
		}
		public ActionResult Index()
		{
			return View(cust.GetAllCustomer());
		}
	}
}
