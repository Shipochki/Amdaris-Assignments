
namespace Assignment_SOLID_Principles.Email.Templates
{
	public class InvalidMessage : MessageTemplate
	{
		public override string Message(string receiverMail, string message)
		{
			return $"Status - Error send message: {message} to {receiverMail}";
		}
	}
}
