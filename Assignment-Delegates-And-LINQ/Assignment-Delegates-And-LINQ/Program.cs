namespace Assignment_Delegates_And_LINQ
{
	internal class Program
	{
		public delegate void Print(string value);
		public delegate void PrintCount(int value);

		static void Main(string[] args)
		{
			//Service
			UserService userService = new UserService();

			//Anonymous method
			Print print = Console.WriteLine;

			//Anonymous method with lambda expression
			PrintCount printCount = value => Console.WriteLine($"Count is {value}");

			User user1 = userService.Find(u => u.Name == "Nikola");
			//Using extension method Info
			print(user1.Info());

            Console.WriteLine();
            User user2 = userService.Find(u => u.Email == "stefan@gmail.com");
			//Using extension method Info
			print(user2.Info());

			//Function
			Func<User, User, bool> Compare = (user1, user2) => user1.Name == user2.Name;

			//Action
			Action<string> greet = name => Console.WriteLine($"Hello, {name}");

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
