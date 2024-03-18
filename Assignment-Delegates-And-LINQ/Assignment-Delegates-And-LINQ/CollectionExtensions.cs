namespace Assignment_Delegates_And_LINQ
{
	public static class CollectionExtensions
	{
		public static int CountValidNames(this List<User> users)
		{
			return users.Where(u => u.Name != null).Count();
		}
	}
}
