namespace Assignment_Behavioral_Design_Patterns
{
	using Assignment_Behavioral_Design_Patterns.Entities;
	using Assignment_Behavioral_Design_Patterns.Extensions;
	using Assignment_Behavioral_Design_Patterns.Repository;

	public class BookStore
	{
		public void Run()
		{
			Repository<User> userRepository = new Repository<User>(new DbContext<User>());
			int penko = userRepository.Add(new User() { Name = "Penko", Email = "penko@abv.bg", Role = Enums.Role.Customer, IsSubscribe = false });
			int stefan = userRepository.Add(new User() { Name = "Stefan", Email = "stefan@gmail.com", Role = Enums.Role.Staff, IsSubscribe = false });
			int nikola = userRepository.Add(new User() { Name = "Nikola", Email = "nikola@gmail.com", Role = Enums.Role.Staff, IsSubscribe = true });

			Repository<Order> orderRepository = new Repository<Order>(new DbContext<Order>());

			Repository<Book> bookRepository = new Repository<Book>(new DbContext<Book>());
			int potter1 = bookRepository.Add(new Book() { Name = "Harry Potter and the Philosopher's Stone" });
			int potter2 = bookRepository.Add(new Book() { Name = "Harry Potter and the Chamber of Secrets" });
			int potter3 = bookRepository.Add(new Book() { Name = "Harry Potter and the Prisoner of Azkaban" });

			//Subscribing
			userRepository.GetEntityById(penko)?.Subscribe();
			userRepository.GetEntityById(stefan)?.Subscribe();

			//Unsubscribing
			userRepository.GetEntityById(nikola)?.UnSubscribe();

			Order order = new Order()
			{
				User = userRepository.GetEntityById(penko) ?? new User(),
			};
			order.Books.Add(bookRepository.GetEntityById(potter1) ?? new Book());
			order.Books.Add(bookRepository.GetEntityById(potter3) ?? new Book());

			//Place an order
			int orderId = orderRepository.Add(order);

            //Send message to user and staff
			//Send message to order.user
            Console.WriteLine($"Succefuly place an order with number: {orderId}");

			//Staff message to staff
			Console.WriteLine($"Added order with number {orderId} for fulfillment");

			Thread.Sleep(3000);

            for (int i = 1; i <= 10; i++)
            {
				Console.Clear();
                Console.WriteLine($"Loading: {i}0%/100%");
				Thread.Sleep(300);
            }

            //Send message to user
            //order.user
            Console.WriteLine($"Order is waiting for shipping with number: {orderId}");

			//Send message to staff
			Console.WriteLine($"Order with number: {orderId} is ready for shipping!");
        }
	}
}
