namespace Assignment_SOLID_Principles
{
	using Assignment_SOLID_Principles.Email;
	using Assignment_SOLID_Principles.Notification;
	using Assignment_SOLID_Principles.Sms;

	public static class Engine
	{
		public static void Run()
		{
			Console.WriteLine("Choose provider:");
			Console.WriteLine("1 - Email");
			Console.WriteLine("2 - Sms");
			Console.WriteLine("3 - Notification");
			string provider = Console.ReadLine();

			if (provider == "1" || provider.ToLower() == "email")
			{
				Console.WriteLine("Email:");
				EmailSender emailSender = new EmailSender();
				Console.WriteLine("Write reciver mail:");
				string reciverMail = Console.ReadLine();
				Console.WriteLine("Write message:");
				string message = Console.ReadLine();
				Console.Clear();
				Console.WriteLine("Email info:");
				emailSender.SendMail(reciverMail, $"\"{message}\"");
			}
			else if (provider == "2" || provider.ToLower() == "sms")
			{
				Console.WriteLine("Sms:");
                Console.WriteLine("Write Sender phone number");
				string senderNumber = Console.ReadLine();
                SmsProvider smsProvider = new SmsProvider(new SmsSender(senderNumber));
				Console.WriteLine("Write reciver number:");
				string reciverNumber = Console.ReadLine();
				Console.WriteLine("Write message:");
				string message = Console.ReadLine();
				Console.Clear();
                Console.WriteLine("Sms info:");
                smsProvider.Send(reciverNumber, message);
			}
			else if(provider == "3" ||  provider.ToLower() == "notification")
			{
				Console.WriteLine("Notification:");
				NotificationSender notificationSender = new NotificationSender();
                Console.WriteLine("Choose notification type:");
                Console.WriteLine("1 - Text");
                Console.WriteLine("2 - Media");
                string type = Console.ReadLine();
				if(type == "1" || type.ToLower() == "text")
				{
					type = "text";
                    Console.WriteLine("Write message:");
                }
				else if(type == "2" || type.ToLower() == "media")
				{
					type = "media";
					Console.WriteLine("Write media link:");
				}
				else
				{
                    Console.WriteLine("Invalid type");
                    return;
				}
				string textOrMedia = Console.ReadLine();
				Console.Clear();
                Console.WriteLine("Notification info:");
                notificationSender.SendNotification(type, textOrMedia);
			}
			else
			{
				Console.Clear();
                Console.WriteLine("Invalid provider");
            }
		}
	}
}
