namespace Assignment_SOLID_Principles.Email.Templates
{
	public class SuccesfulMessage : IMessageTemplate
	{
		public string Message(string receiverMail, string message)
		{
			return $"Succesful send message: {message} to {receiverMail}";
		}
	}
}
