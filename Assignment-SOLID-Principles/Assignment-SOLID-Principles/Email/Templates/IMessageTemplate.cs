namespace Assignment_SOLID_Principles.Email.Templates
{
	public interface IMessageTemplate
	{
		string Message(string receiverMail, string message);
	}
}
