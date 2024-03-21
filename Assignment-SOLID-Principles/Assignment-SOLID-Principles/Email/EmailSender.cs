namespace Assignment_SOLID_Principles.Email
{
	using Assignment_SOLID_Principles.Email.Templates;

	public class EmailSender : IEmailSender
	{
		private string _senderMail = "sender@gmail.com";

		public void SendEmail(string receiverMail, string message)
		{
			try
			{
				Console.WriteLine($"{_senderMail} send message to {receiverMail}");
				SuccesfulMessage succesfulMessage = new SuccesfulMessage();
				Console.WriteLine(succesfulMessage.Message(receiverMail, message));
			}
			catch (Exception)
			{
				InvalidMessage invalidMessage = new InvalidMessage();
				Console.WriteLine(invalidMessage.Message(receiverMail, message));
			}
		}

		public void SetSenderMail(string senderMail)
		{
			_senderMail = senderMail;
		}

		public string SenderMail => _senderMail;
	}
}
