using Assignment_Behavioral_Design_Patterns.Enums;

namespace Assignment_Behavioral_Design_Patterns.Entities
{
    public class User : Entity
	{
		public string Name { get; set; } = null!;

		public string Email { get; set; } = null!;

		public Role Role { get; set; }

		public List<Order> MyOrders { get; set; } = new List<Order>();

		public List<Order> SubscribedOrders { get; set; } = new List<Order>();
	}
}
