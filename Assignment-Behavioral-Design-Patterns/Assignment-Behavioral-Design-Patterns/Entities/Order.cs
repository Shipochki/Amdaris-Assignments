namespace Assignment_Behavioral_Design_Patterns.Entities
{
	public class Order : Entity
	{
		public User User { get; set; } = null!;
		public List<Book> Books { get; set; } = new List<Book>();
	}
}
