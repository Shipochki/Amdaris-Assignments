﻿namespace Assignment_SOLID_Principles.Email.Templates
{
	public class SuccesfulMessage : MessageTemplate
	{
		public override string Message(string receiverMail, string message)
		{
			return $"Succesful send message: {message} to {receiverMail}";
		}
	}
}
