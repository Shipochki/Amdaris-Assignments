namespace Assignment_Behavioral_Design_Patterns.Extensions
{
	using Assignment_Behavioral_Design_Patterns.Entities;

	public static class UserExtensions
	{
		public static void Subscribe(this User user)
		{
			user.IsSubscribe = true;
		}

		public static void UnSubscribe(this User user)
		{
			user.IsSubscribe = false;
		}
	}
}
