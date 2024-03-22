namespace Assignment_SOLID_Principles.Email
{
	using Assignment_SOLID_Principles.Email.Templates;

	public class EmailSender : IEmailSender, IEmailWriter
	{
		private string _senderMail = "sender@gmail.com";

		public void SendMail(string receiverMail, string message)
		{
			MessageTemplate? messageType = null;

			try
			{
				//write message to receiver
				MessageWriter(receiverMail);

				//Stauts for message
				messageType = new SuccesfulMessage();
				Console.WriteLine(messageType.Message(receiverMail, message));
			}
			catch (ArgumentException m)
			{
                Console.WriteLine(m.Message);

				//Status for message
				messageType = new InvalidMessage();
                Console.WriteLine(messageType.Message(receiverMail, message));
			}
		}

		public void SetSenderMail(string senderMail)
		{
			_senderMail = senderMail;
		}

		public void MessageWriter(string receiverMail)
		{
			if(!receiverMail.Contains("@"))
			{
				throw new ArgumentException("Invalid mail");
			}

            Console.WriteLine($"{_senderMail} send message to {receiverMail}");
        }

		public string SenderMail => _senderMail;
	}
}
