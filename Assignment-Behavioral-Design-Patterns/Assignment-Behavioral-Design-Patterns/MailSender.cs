namespace Assignment_Behavioral_Design_Patterns
{
	using Assignment_Behavioral_Design_Patterns.Entities;

	public class MailSender : ISender
	{
		public void SendSuccessfulOrder(List<User> staff, User customer, Order order)
		{
			if (IsContainsOrder(customer, order))
			{
				AddTextToMessage($"Hello, {customer.Name} thank you for your order with number: {order.Id}");
				AddTextToMessage("Your ordered products:");
				AddBooksToMessage(order.Books);
				Console.WriteLine();
			}

			foreach (var user in staff.Where(u => IsContainsOrder(u, order)))
			{
				AddTextToMessage($"StaffMessage - {user.Name} - New order with number: {order.Id}");
				AddTextToMessage("Order products:");
				AddBooksToMessage(order.Books);
				Console.WriteLine();
			}
		}

		public void SendOrderForShipping(List<User> staff, User customer, Order order)
		{
			if (IsContainsOrder(customer, order))
			{
				AddTextToMessage($"Hello, {customer.Name} your order with number: {order.Id} is ready for shipping!");
			}

			foreach (var user in staff.Where(u => IsContainsOrder(u, order)))
			{
				AddTextToMessage($"StaffMessage - {user.Name} - Order with number: {order.Id} is ready for Shipping!!!");
			}
		}

		private bool IsContainsOrder(User user, Order order)
		{
			return user.SubscribedOrders.Contains(order);
		}

		private void AddBooksToMessage(List<Book> books)
		{
			foreach (Book book in books)
			{
				Console.WriteLine($" -- {book.Name}");
			}
		}

		private void AddTextToMessage(string text)
		{
            Console.WriteLine(text);
        }
	}
}
