
namespace Assignment_SOLID_Principles.Email.Templates
{
	public class InvalidMessage : MessageTemplate
	{
		public override string Message(string receiverMail, string message)
		{
			return $"Error send message: {message} to {receiverMail}";
		}
	}
}
