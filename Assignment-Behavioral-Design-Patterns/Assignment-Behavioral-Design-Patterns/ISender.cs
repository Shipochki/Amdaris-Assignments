namespace Assignment_Behavioral_Design_Patterns
{
	using Assignment_Behavioral_Design_Patterns.Entities;

	public interface ISender
	{
		void SendSuccessfulOrder(List<User> staff, User customer, Order order);

		void SendOrderForShipping(List<User> staff, User custoner, Order order);
	}
}
