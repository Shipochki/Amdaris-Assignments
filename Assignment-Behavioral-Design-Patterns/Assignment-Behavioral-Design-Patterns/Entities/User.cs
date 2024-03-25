using Assignment_Behavioral_Design_Patterns.Enums;

namespace Assignment_Behavioral_Design_Patterns.Entities
{
    public class User : Entity
	{
		public string Name { get; set; } = null!;

		public string Email { get; set; } = null!;

		public bool IsSubscribe { get; set; }

		public Role Role { get; set; }

		public List<Order> Orders { get; set; } = new List<Order>();
	}
}
