namespace Assignment_SOLID_Principles.Email
{
	public interface IEmailSender
	{
		public void SendEmail(string receiver, string message);
	}
}
