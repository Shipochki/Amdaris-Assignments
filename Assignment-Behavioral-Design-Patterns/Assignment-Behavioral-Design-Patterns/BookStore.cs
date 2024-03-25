namespace Assignment_Behavioral_Design_Patterns
{
	using Assignment_Behavioral_Design_Patterns.Entities;
	using Assignment_Behavioral_Design_Patterns.Extensions;
	using Assignment_Behavioral_Design_Patterns.Repository;

	public class BookStore
	{
		private readonly Repository<User> _userRepository;
		private readonly Repository<Order> _orderRepository;
		private readonly Repository<Book> _bookRepository;
		private readonly MailSender _sender;

		public BookStore()
		{
			_userRepository = new Repository<User>(new DbContext<User>());
			_orderRepository = new Repository<Order>(new DbContext<Order>());
			_bookRepository = new Repository<Book>(new DbContext<Book>());
			_sender = new MailSender();
		}

		public void Run()
		{
			SetData();

			//Subscribing
			_userRepository
				.GetAll()
				.FirstOrDefault(u => u.Email == "penko@abv.bg")?
				.Subscribe();

			_userRepository
				.GetAll()
				.FirstOrDefault(u => u.Email == "stefan@gmail.com")?
				.Subscribe();

			//Unsubscribing
			_userRepository
				.GetAll()
				.FirstOrDefault(u => u.Email == "nikola@gmail.com")?
				.UnSubscribe();

			List<User> staff = _userRepository
							.GetAll()
							.Where(u => u.Role.Equals(Enums.Role.Staff))
							.ToList();

			//Place an order
			Order order = PlaceAnOrder(staff);

			Preparing(order, staff);
		}

		public Order PlaceAnOrder(List<User> staff)
		{
			User user = _userRepository
				.GetAll()
				.FirstOrDefault(u => u.Email == "penko@abv.bg") ?? new User();

			Book book1 = _bookRepository
					.GetAll()
					.FirstOrDefault(c => c.Name == "Harry Potter and the Philosopher's Stone") ?? new Book();

			Book book2 = _bookRepository
					.GetAll()
					.FirstOrDefault(c => c.Name == "Harry Potter and the Prisoner of Azkaban") ?? new Book();

			Order order = new Order()
			{
				User = user,
				Books =
				{
					book1,
					book2
				}
			};

			int orderId = _orderRepository
				.Add(order);

			_sender.SendSuccessfulOrder(staff, user, order);

			return order;
		}

		public void SetData()
		{
			_userRepository.Add(new User() { Name = "Penko", Email = "penko@abv.bg", Role = Enums.Role.Customer, IsSubscribe = false });
			_userRepository.Add(new User() { Name = "Stefan", Email = "stefan@gmail.com", Role = Enums.Role.Staff, IsSubscribe = false });
			_userRepository.Add(new User() { Name = "Nikola", Email = "nikola@gmail.com", Role = Enums.Role.Staff, IsSubscribe = true });
			_userRepository.Add(new User() { Name = "Ivan", Email = "ivan@abv.bg", Role = Enums.Role.Staff, IsSubscribe = true });

			_bookRepository.Add(new Book() { Name = "Harry Potter and the Philosopher's Stone" });
			_bookRepository.Add(new Book() { Name = "Harry Potter and the Chamber of Secrets" });
			_bookRepository.Add(new Book() { Name = "Harry Potter and the Prisoner of Azkaban" });
		}

		private void Preparing(Order order, List<User> staff)
		{
			for (int i = 1; i <= 10; i += 2)
			{
				Console.WriteLine($"Preparing: {i}0%/100%");
				Thread.Sleep(300);
			}

			order.IsReadyForShipping = true;
			
			_sender.SendOrderForShipping(staff, order.User, order);
		}
	}
}
