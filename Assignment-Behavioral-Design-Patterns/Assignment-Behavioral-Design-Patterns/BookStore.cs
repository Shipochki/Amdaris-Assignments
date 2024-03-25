namespace Assignment_Behavioral_Design_Patterns
{
	using Assignment_Behavioral_Design_Patterns.Entities;
	using Assignment_Behavioral_Design_Patterns.Repository;

	public class BookStore
	{
		public void Run()
		{
			Repository<User> userRepository = new Repository<User>(new DbContext<User>());
			userRepository.Add(new User() { Name = "Penko", Email = "penko@abv.bg", Role = Enums.Role.Customer, IsSubscribe = false });
			userRepository.Add(new User() { Name = "Stefan", Email = "stefan@gmail.com", Role = Enums.Role.Staff, IsSubscribe = false });

			Repository<Order> orderRepository = new Repository<Order>(new DbContext<Order>());

			Repository<Book> bookRepository = new Repository<Book>(new DbContext<Book>());
			bookRepository.Add(new Book() { Name = "Harry Potter and the Philosopher's Stone" });
			bookRepository.Add(new Book() { Name = "Harry Potter and the Chamber of Secrets" });
			bookRepository.Add(new Book() { Name = "Harry Potter and the Prisoner of Azkaban" });
			


		}
	}
}
