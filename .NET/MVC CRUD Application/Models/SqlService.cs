namespace MVCASSIGNMENT1.Models
{
	public class SqlService : IsqlRepository
	{
		BookContext Context;
        public SqlService(BookContext context)
        {
            Context = context;
        }
        public Book AddBook(Book book)
		{
			Context.Books.Add(book);
			Context.SaveChanges();
			return book;
		}

		public Book DeleteById(int id)
		{
			Book b=Context.Find<Book>(id);
			Context.Remove(b);
			Context.SaveChanges();
			return b;
		}

		public IEnumerable<Book> GetAllBook()
		{
			return Context.Books;
		}

		public Book GetById(int id)
		{
			return Context.Find<Book>(id);
		}

		public Book UpdateBook(Book book)
		{
			Context.Books.Attach(book);
			Context.Update(book);
			Context.SaveChanges();
			return book;
		}

		public Book GetBook(int Id)
		{
			return Context.Books.Find(Id);
		}
	}
}
