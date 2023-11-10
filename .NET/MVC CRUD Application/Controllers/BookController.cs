using Microsoft.AspNetCore.Mvc;
using MVCASSIGNMENT1.Models;

namespace MVCASSIGNMENT1.Controllers
{
	public class BookController : Controller
	{
		private IsqlRepository _isqlRepository;

		public BookController(IsqlRepository isqlRepository)
		{
			_isqlRepository = isqlRepository;
		}


		public ActionResult Index()
		{
			var model = _isqlRepository.GetAllBook();
			return View(model);
		}


		//Get :BookController/Create
		public ActionResult AddBook()
		{
			return View();
		}

		//Post :BookController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult AddBook(Book book)
		{
			try
			{
				var model = _isqlRepository.AddBook(book);
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex)
			{
				return View();
			}
		}

		//Read 
		public ActionResult GetId(int Id)
		{
			var model = _isqlRepository.GetById(Id);
			return View(model);
		}

		// GET: BookController/Edit/5
		public ActionResult Edit(int Id)
		{
			var model = _isqlRepository.GetBook(Id);
			return View(model);

		}
		//Post
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int Id, Book book)
		{
			try
			{
				var model = _isqlRepository.UpdateBook(book);

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}


		// GET: EmployeeController/Delete/5
		public ActionResult Delete(int Id)
		{
			var model = _isqlRepository.GetBook(Id);
			return View(model);

		}

		[HttpPost]
		[ValidateAntiForgeryToken]

        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var model = _isqlRepository.DeleteById(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



    }
}
