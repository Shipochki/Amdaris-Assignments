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
			SetData();
		}

		public void Run()
		{
			List<User> staff = _userRepository
							.GetAll()
							.Where(u => u.Role.Equals(Enums.Role.Staff))
							.ToList();

			User user = _userRepository
							.GetAll()
							.FirstOrDefault(u => u.Email == "penko@abv.bg") ?? new User();

			List<Book> books = _bookRepository.GetAll().Take(2).ToList();

			//Place an order
			Order order = PlaceAnOrder(staff, user, books);

			//Unsubscribing
			_userRepository
				.GetAll()
				.FirstOrDefault(u => u.Email == "nikola@gmail.com")?
				.UnSubscribe(order);

			Preparing(order, staff);
		}

		public Order PlaceAnOrder(List<User> staff, User user, List<Book> books)
		{
			Order order = new Order()
			{
				User = user,
				Books = books
			};

			_orderRepository
				.Add(order);

			//Subscribing
			user.Subscribe(order);

			foreach (var userStaff in staff)
			{
				userStaff.Subscribe(order);
			}

			_sender.SendSuccessfulOrder(staff, user, order);

			order.Status = "Successfully created";

			return order;
		}

		public void SetData()
		{
			_userRepository.Add(new User() { Name = "Penko", Email = "penko@abv.bg", Role = Enums.Role.Customer });
			_userRepository.Add(new User() { Name = "Stefan", Email = "stefan@gmail.com", Role = Enums.Role.Staff });
			_userRepository.Add(new User() { Name = "Nikola", Email = "nikola@gmail.com", Role = Enums.Role.Staff });
			_userRepository.Add(new User() { Name = "Ivan", Email = "ivan@abv.bg", Role = Enums.Role.Staff });

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

			order.Status = "Order is ready for shipping";

			_sender.SendOrderForShipping(staff, order.User, order);
		}
	}
}
