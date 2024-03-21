namespace Assignment_SOLID_Principles
{
	using Assignment_SOLID_Principles.Email;

	internal class Program
	{
		static void Main(string[] args)
		{
			EmailSender emailSender = new EmailSender();
			emailSender.SendEmail("receiver@gmail.com", "Hello, receiver");
		}
	}
}
