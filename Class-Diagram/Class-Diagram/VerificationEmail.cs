namespace Class_Diagram
{
	public class VerificationEmail
	{
		public int Id { get; set; }
		public string Email { get; set; } = null!;

		public string VerificationCode { get; set; } = null!;

		public int UserId { get; set; }

		public User User { get; set; } = null!;
	}
}
