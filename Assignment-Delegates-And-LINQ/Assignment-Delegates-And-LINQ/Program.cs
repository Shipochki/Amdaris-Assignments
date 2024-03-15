namespace Assignment_Delegates_And_LINQ
{
	using static UserExtensions;
	internal class Program
	{
		public delegate void Print(string value);
		public delegate void PrintCount(int value);

		static void Main(string[] args)
		{
			//Service
			UserService userService = new UserService();

			//Anonymous method
			Print print = delegate (string value)
						{
							Console.WriteLine(value);
						};

			//Anonymous method with lambda expression
			PrintCount printCount = value => Console.WriteLine($"Count is {value}");

			User user1 = userService.Find(u => u.Name == "Nikola");
			print(user1.Info());

            Console.WriteLine();
            User user2 = userService.Find(u => u.Email == "stefan@gmail.com");
			print(user2.Info());

            Console.WriteLine();
            printCount(userService.CountUser);

			var user3 = userService
				.Users
				.Where(u => u.Name == "Tinko")
				.Select(u => new { u.Email })
				.FirstOrDefault();

            Console.WriteLine();
            if (user3 != null) print($"Email: {user3.Email}");
		}
	}
}
