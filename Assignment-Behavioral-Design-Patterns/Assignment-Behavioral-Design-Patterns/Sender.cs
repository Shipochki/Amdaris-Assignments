using Assignment_Behavioral_Design_Patterns.Entities;

namespace Assignment_Behavioral_Design_Patterns
{
	public class Sender : ISender
	{
		public void SendMessageToCustomer(int customerId, int orderId)
		{
			Console.WriteLine($"Succefuly place an order with number: {orderId}");
		}

		public void SendMessageToStaff(int orderId)
		{
			throw new NotImplementedException();
		}
	}
}
