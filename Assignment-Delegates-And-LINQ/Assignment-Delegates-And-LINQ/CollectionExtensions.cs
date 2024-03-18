namespace Assignment_Delegates_And_LINQ
{
	public static class CollectionExtensions
	{
		/// <summary>
		/// Extension method for collection
		/// </summary>
		/// <param name="users"></param>
		/// <returns></returns>
		public static int CountValidNames(this List<User> users)
		{
			return users.Where(u => u.Name != null).Count();
		}
	}
}
