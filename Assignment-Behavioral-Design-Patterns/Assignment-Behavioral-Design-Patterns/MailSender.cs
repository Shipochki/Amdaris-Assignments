namespace Assignment_Behavioral_Design_Patterns
{
	using Assignment_Behavioral_Design_Patterns.Entities;

	public class MailSender : ISender
	{
		public void SendSuccessfulOrder(List<User> staff, User customer, Order order)
		{
			if (customer.IsSubscribe == true)
			{
				Console.WriteLine($"Hello, {customer.Name} thank you for your order with number: {order.Id}");
                Console.WriteLine("Your ordered products:");
				foreach (Book book in order.Books)
				{
                    Console.WriteLine($" -- {book.Name}");
                }
                Console.WriteLine();
            }

			foreach (var user in staff.Where(u => u.IsSubscribe == true))
			{
				Console.WriteLine($"StaffMessage - {user.Name} - New order with number: {order.Id}");
				Console.WriteLine("Order products:");
				foreach (Book book in order.Books)
				{
					Console.WriteLine($" -- {book.Name}");
				}
                Console.WriteLine();
            }
		}

		public void SendOrderForShipping(List<User> staff, User customer, Order order)
		{
			if (customer.IsSubscribe == true)
			{
				Console.WriteLine($"Hello, {customer.Name} your order with number: {order.Id} is ready for shipping!");
			}

			foreach (var user in staff.Where(u => u.IsSubscribe == true))
			{
				Console.WriteLine($"StaffMessage - {user.Name} - Order with number: {order.Id} is ready for Shipping!!!");
			}
		}
	}
}
