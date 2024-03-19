namespace Class_Diagram
{
	public class Role
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public int UserId { get; set; }
		public User User { get; set; } = null!;
	}
}
