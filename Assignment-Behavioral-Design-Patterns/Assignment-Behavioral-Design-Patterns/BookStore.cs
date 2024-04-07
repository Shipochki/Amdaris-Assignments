namespace Assignment_Behavioral_Design_Patterns
{
	using Assignment_Behavioral_Design_Patterns.Entities;
	using Assignment_Behavioral_Design_Patterns.Enums;

	public class BookStore
	{
		private Publisher _publisher;
		private List<User> _staff;
		//private Dictionary<int, Publisher> _orderPublisher;

		public BookStore()
		{
			_publisher = new Publisher();
			_staff = new List<User>()
			{
				{new User() {
					Name = "Penko",
					Role = Role.Staff
				}},
				{new User()
				{
					Name = "Stefan",
					Role = Role.Staff
				}
				}
			};
			//_orderPublisher = new Dictionary<int, Publisher>();
		}

		public void CreateOrder(List<Book> books, User client)
		{
			_publisher.AddSubscriber(client);
			User? staff = _staff.FirstOrDefault(s => !_publisher.IsSubscribed(s));
			//User? staff = _staff.FirstOrDefault(s => _orderPublisher.Any(p => !p.Value.IsSubscribed(s)));

			_publisher.AddSubscriber(staff);

			Order order = new Order
			{
				Id = 1,
				Books = books,
				Status = Status.Created
			};

			//_orderPublisher.Add(order.Id, new Publisher());
			//_orderPublisher[order.Id].AddSubscriber(client);
			//_orderPublisher[order.Id].AddSubscriber(staff);
			//_orderPublisher[order.Id].Publish(order);

			_publisher.Publish(order);

			Preparing(order);
		}

		private void Preparing(Order order)
		{
			Thread.Sleep(3000);

			order.Status = Status.ReadyForShipping;

			//_orderPublisher[order.Id].Publish(order);
			_publisher.Publish(order);
		}
	}
}
