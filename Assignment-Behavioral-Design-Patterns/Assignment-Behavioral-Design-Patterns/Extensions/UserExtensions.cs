namespace Assignment_Behavioral_Design_Patterns.Extensions
{
	using Assignment_Behavioral_Design_Patterns.Entities;

	public static class UserExtensions
	{
		public static void Subscribe(this User user, Order order)
		{
			user.SubscribedOrders.Add(order);
		}

		public static void UnSubscribe(this User user, Order order)
		{
			user.SubscribedOrders.Remove(order);
		}
	}
}
