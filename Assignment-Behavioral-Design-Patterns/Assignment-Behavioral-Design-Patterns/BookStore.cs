namespace Assignment_Behavioral_Design_Patterns
{
	using Assignment_Behavioral_Design_Patterns.Entities;
	using Assignment_Behavioral_Design_Patterns.Enums;

	public class BookStore
	{
		private Publisher _publisher;
		private List<User> _staff;

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
		}

		public void CreateOrder(List<Book> books, User client)
		{
			_publisher.AddSubscriber(client);
			User? staff = _staff.FirstOrDefault(s => !_publisher.IsSubscribed(s));

			_publisher.AddSubscriber(staff);

			Order order = new Order
			{
				Books = books,
				Status = Status.Created
			};

			_publisher.Publish(order);

			Preparing(order);
		}

		private void Preparing(Order order)
		{
			Thread.Sleep(3000);

			order.Status = Status.ReadyForShipping;

			_publisher.Publish(order);
		}
	}
}
