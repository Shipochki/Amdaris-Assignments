﻿
namespace Assignment_SOLID_Principles.Notification.NotificationType
{
	public class MediaNotification : BaseNotification
	{
		public override string Notification(string input)
		{
			return $"Send media notification - MediaLink: {input}";
		}
	}
}
