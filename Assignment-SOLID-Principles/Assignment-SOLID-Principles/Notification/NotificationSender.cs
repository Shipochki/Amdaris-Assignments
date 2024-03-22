namespace Assignment_SOLID_Principles.Notification
{
	using Assignment_SOLID_Principles.Notification.NotificationType;

	public class NotificationSender : INotificationSender
	{
		public void SendNotification(string type, string textOrMedia)
		{
			BaseNotification? notifi = null;

			if (type == "media")
			{
				notifi = new MediaNotification();
				Console.WriteLine(notifi.Notification(textOrMedia));
			}
			else if (type == "text")
			{
				notifi = new TextNotification();
				Console.WriteLine(notifi.Notification(textOrMedia));
			}
		}
	}
}
