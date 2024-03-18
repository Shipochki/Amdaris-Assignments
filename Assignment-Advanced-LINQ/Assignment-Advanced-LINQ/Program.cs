using System.Collections.ObjectModel;

namespace Assignment_Advanced_LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			User stefan = new User() { Name = "Stefan" };
			User nikola = new User() { Name = "Nikola" };
			User penko = new User() { Name = "Penko" };
			List<User> users = new List<User>() { stefan, nikola, penko };

			Post post1 = new Post() { Topic = "Space", Creator = stefan };
			Post post2 = new Post() { Topic = "News", Creator = nikola };
			Post post3 = new Post() { Topic = "IT", Creator = penko };
			Post post4 = new Post() { Topic = "Nature", Creator = stefan };
			Post post5 = new Post() { Topic = "Future", Creator = nikola };
			Post post6 = new Post() { Topic = "News2", Creator = stefan };
			List<Post> posts = new List<Post>() {  post1, post2, post3, post4, post5, post6 };

			JoinMethod(users, posts);
            Console.WriteLine();
            GroupJoinMethod(users, posts);
            Console.WriteLine();
			ZipMethod();
            Console.WriteLine();
			GroupByMethod(posts);
            Console.WriteLine();
			SetOperatosMethod();
            Console.WriteLine();
			ConverstionMethod();
        }

		static void JoinMethod(List<User> users, List<Post> posts)
		{
			var result = users.Join(posts,
				creator => creator,
				posts => posts.Creator,
				(creator, post) => new { CreatorName = creator.Name, PostName = post.Topic });

            Console.WriteLine("Join Example:");
            foreach (var item in result)
            {
                Console.WriteLine($"Creator: {item.CreatorName} - Topic: {item.PostName}");
            }
        }

		static void GroupJoinMethod(List<User> users, List<Post> posts)
		{
			var result = users.GroupJoin(posts,
				creator => creator,
				post => post.Creator,
				(creator, post) => new { CreatorName = creator.Name, Posts = post });

            Console.WriteLine("GroupJoin Example:");
            foreach (var creator in result)
            {
                Console.WriteLine($"Creator: {creator.CreatorName}");
                foreach (var post in creator.Posts)
                {
                    Console.WriteLine($" - {post.Topic}");
                }
            }
        }

		static void ZipMethod()
		{
			List<string> list1 = new List<string>() { "1", "2", "3" };
			List<string> list2 = new List<string>() { "a", "b", "c" };

            Console.WriteLine("Zip Example:");
            var result = list1.Zip(list2, (a, b) => a + b);
            Console.WriteLine(string.Join(" ", result));
        }

		static void GroupByMethod(List<Post> posts)
		{
			var result = posts
				.GroupBy(p => p.Creator);

            Console.WriteLine($"GroupByMethod Example:");
            foreach (var post in result)
            {
                Console.WriteLine($"Creator: {post.Key.Name}");
            }
        }

		static void SetOperatosMethod()
		{
			List<string> list1 = new List<string>() { "1", "2", "3", "c" };
			List<string> list2 = new List<string>() { "a", "b", "c" };

			var concat = list1.Concat(list2).ToList();
			var union = list1.Union(list2).ToList();
			var intersect = list1.Intersect(list2).ToList();
			var except = list1.Except(list2).ToList();

            Console.WriteLine("SetOperatosMethod Example:");
            Console.WriteLine($"Concat - {string.Join(" ", concat)}");
			Console.WriteLine($"Union - {string.Join(" ", union)}");
			Console.WriteLine($"Intersect - {string.Join(" ", intersect)}");
			Console.WriteLine($"Except - {string.Join(" ", except)}");
        }

		static void ConverstionMethod()
		{
            Console.WriteLine("ConverstionMethod Example:");
			//OfType
            var list1 = new Collection<object>() { "car1", "car2", "car3", 5.0 };
			var ofTypeResult = list1.OfType<string>();
			Console.WriteLine($"OfType - {string.Join(" ", ofTypeResult)}");

			//Cast
			List<object> list2 = new List<object>() { "car2", "car1", "car3" };
			IEnumerable<string> query1 =
				list2.Cast<string>().OrderByDescending(c => c).Select(c => c);
			Console.WriteLine($"Cast - {string.Join(" ", query1)}");

			//ToArray
			List<string> list3 = new List<string>() { "car2", "car1", "car3" };
			string[] toArray = list3.ToArray();
			Console.WriteLine($"ToArray - {string.Join(" ", toArray)}");

			//ToDictionary

		}
	}
}
