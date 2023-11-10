using Microsoft.EntityFrameworkCore;

namespace MVCASSIGNMENT1.Models

{
	public class BookContext:DbContext
	{
        public BookContext(DbContextOptions<BookContext> options):base(options) {
		
		}


        public DbSet<Book> Books { get; set; }
		public DbSet<Author> Author { get; set; }
	}
}
