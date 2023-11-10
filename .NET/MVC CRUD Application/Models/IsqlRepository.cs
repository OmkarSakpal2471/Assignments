namespace MVCASSIGNMENT1.Models
{
	public interface IsqlRepository
	{
		IEnumerable<Book> GetAllBook();
		Book GetById(int id);
		Book DeleteById(int id);
		Book AddBook(Book book);
		Book UpdateBook(Book book);
		public Book GetBook(int Id);


    }
}
