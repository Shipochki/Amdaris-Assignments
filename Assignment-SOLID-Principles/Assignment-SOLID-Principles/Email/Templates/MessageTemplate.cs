namespace Assignment_SOLID_Principles.Email.Templates
{
	public abstract class MessageTemplate
	{
		public abstract string Message(string receiverMail, string message);
	}
}
