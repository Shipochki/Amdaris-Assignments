namespace Assignment_Delegates_And_LINQ
{
	public static class UserExtensions
	{
		/// <summary>
		/// Extension method
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		public static string Info(this User user)
		{
			return $"{user.Name} : {user.Email}";
		}
	}
}
