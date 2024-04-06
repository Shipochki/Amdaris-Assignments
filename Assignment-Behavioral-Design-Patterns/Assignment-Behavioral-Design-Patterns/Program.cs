using Assignment_Behavioral_Design_Patterns.Entities;
using Assignment_Behavioral_Design_Patterns.Enums;

namespace Assignment_Behavioral_Design_Patterns
{
	internal class Program
	{
		static void Main(string[] args)
		{
			User ivan = new User()
			{
				Name = "Ivan",
				Role = Role.Client
			};

			List<Book> books = new List<Book>
			{
				{ new Book(){Name = "Book1", Price = 5 } },
				{ new Book(){Name = "Book2", Price = 10} }
			};

			BookStore bookStore = new BookStore();
			bookStore.CreateOrder(books, ivan);
		}
	}
}
