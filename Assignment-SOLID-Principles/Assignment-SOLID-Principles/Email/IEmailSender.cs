namespace Assignment_SOLID_Principles.Email
{
	public interface IEmailSender
	{
		public void SendMail(string receiver, string message);
	}
}
