namespace Assignment_SOLID_Principles
{
	using Assignment_SOLID_Principles.Email;
	using Assignment_SOLID_Principles.Notification;
	using Assignment_SOLID_Principles.Sms;

	internal class Program
	{
		static void Main(string[] args)
		{
			EmailSender emailSender = new EmailSender();
			emailSender.SendEmail("receiver@gmail.com", "\"Hello, receiver\"");

			SmsSender smsSender = new SmsSender("0885323325");
			SmsProvider smsProvider = new SmsProvider(smsSender);
			smsProvider.Send("0897321285", "Hello, mate");

			NotificationSender notificationSender = new NotificationSender();
			notificationSender.SendNotification("text");
		}
	}
}
