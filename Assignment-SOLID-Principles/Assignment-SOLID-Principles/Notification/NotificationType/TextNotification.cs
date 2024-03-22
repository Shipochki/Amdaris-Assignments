namespace Assignment_SOLID_Principles.Notification.NotificationType
{
	public class TextNotification : BaseNotification
	{
		public override string Notification(string input)
		{
			return $"Send text notification: \"{input}\" ";
		}
	}
}
