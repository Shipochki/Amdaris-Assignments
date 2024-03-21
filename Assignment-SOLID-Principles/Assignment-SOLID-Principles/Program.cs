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
			emailSender.SendEmail("receiver@gmail.com", "Hello, receiver");

			SmsSender smsSender = new SmsSender("0888432512");
			smsSender.SmsSend("0897321285", "Hello, mate");

			NotificationSender notificationSender = new NotificationSender();
			notificationSender.SendNotification("media");
		}
	}
}
