
namespace Assignment_SOLID_Principles.Email.Templates
{
	public class InvalidMessage : IMessageTemplate
	{
		public string Message(string receiverMail, string message)
		{
			return $"Error send message: {message} to {receiverMail}";
		}
	}
}
