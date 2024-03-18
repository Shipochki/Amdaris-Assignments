namespace Assignment_Delegates_And_LINQ
{
	public delegate bool CompareDelegate(User user);

	public class UserService
	{
		/// <summary>
		/// Collection
		/// </summary>
		private List<User> _users = new()
		{
			new User() { Name = "Stefan", Email= "stefan@gmail.com"},
			new User() { Name = "Tinko", Email = "tinko@abv.bg"},
			new User() { Name = "Nikola", Email = "nikola@yahoo.com"}
		};

		/// <summary>
		/// Method for manipulation with delegate
		/// </summary>
		/// <param name="compare"></param>
		/// <returns></returns>
		public User Find(CompareDelegate compare)
		{
            foreach (var user in _users)
            {
				if (compare(user))
				{
					return user;
				}
            }
			return null;
        }

		public int CountUsers => _users.Count();

		public List<User> Users => _users;
    }
}
