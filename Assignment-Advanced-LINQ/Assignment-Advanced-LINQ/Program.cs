using System.Collections.ObjectModel;
using System.Linq;

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
			List<Post> posts = new List<Post>() { post1, post2, post3, post4, post5, post6 };

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
			Console.WriteLine();
			AggregationMethod(posts);
            Console.WriteLine();
			QuantifiersMethod(posts);
			Console.WriteLine();
			ElementOperators(posts);
			Console.WriteLine();
			GenerationOperators();
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
                foreach (var item in post)
                {
                    Console.WriteLine($"  -- {item.Topic}");
                }
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
			Console.WriteLine();
			List<object> list2 = new List<object>() { "car2", "car1", "car3" };
			IEnumerable<string> query1 =
				list2.Cast<string>().OrderByDescending(c => c).Select(c => c);
			Console.WriteLine($"Cast - {string.Join(" ", query1)}");

			//ToArray
			Console.WriteLine();
			List<string> list3 = new List<string>() { "car2", "car1", "car3" };
			string[] toArray = list3.ToArray();
			Console.WriteLine($"ToArray - {string.Join(" ", toArray)}");

            //ToList
            Console.WriteLine();
			string[] strings = toArray;
			List<string> list4 = strings.ToList();
			Console.WriteLine($"ToList - {string.Join(" ", list4)}");

			//ToDictionary
			Console.WriteLine();
			List<Package> packages = new List<Package>
			{
				new Package { Company = "Coho Vineyard", Weight = 25.2, TrackingNumber = 89453312L },
				new Package { Company = "Lucerne Publishing", Weight = 18.7, TrackingNumber = 89112755L },
				new Package { Company = "Wingtip Toys", Weight = 6.0, TrackingNumber = 299456122L },
				new Package { Company = "Adventure Works", Weight = 33.8, TrackingNumber = 4665518773L }
			};

			Dictionary<long, Package> dictionary = packages.ToDictionary(p => p.TrackingNumber);
			Console.WriteLine("ToDictionary:");
			foreach (var package in dictionary)
			{
				Console.WriteLine($"  - Key {package.Key}: {package.Value.Company}, {package.Value.Weight} pounds");
			}

			//ToLookup
			Console.WriteLine();
			ILookup<char, string> lookup = packages.ToLookup(p => p.Company[0], p => p.Company + " " + p.TrackingNumber);
			Console.WriteLine("ToLookup:");
			foreach (var packageGroup in lookup)
			{
				Console.WriteLine($" -- Key: {packageGroup.Key}");
				foreach (var str in packageGroup)
				{
					Console.WriteLine($"      {str}");
				}
			}

			//AsEnumerable
			Console.WriteLine();
			List<string> fruitList =
				new List<string> { "apple", "passionfruit", "banana",
				"mango", "orange", "blueberry", "grape", "strawberry" };

			IEnumerable<string> query2 = fruitList.AsEnumerable().Where(f => f.Contains("o"));
			Console.WriteLine($"AsEnumerable - {string.Join(", ", query2)}");

			//AsQueryable
			Console.WriteLine();
			List<int> grades = new List<int>() { 78, 92, 100, 37, 81 };
			IQueryable<int> iqueryable = grades.AsQueryable();

			Console.WriteLine($"AsQueryable - {string.Join(", ", iqueryable)}");
		}

		static void AggregationMethod(List<Post> posts)
		{
			Console.WriteLine($"AggregationMethod:");
			Console.WriteLine($"Count - {posts.Count}");
			Console.WriteLine($"LongCount - {posts.LongCount()}");

			List<int> grades = new List<int>() { 78, 92, 100, 37, 81 };
			Console.WriteLine($"Max - {grades.Max()}");
			Console.WriteLine($"Min - {grades.Min()}");
			Console.WriteLine($"Sum - {grades.Sum()}");
			Console.WriteLine($"Average - {grades.Average()}");
			Console.WriteLine($"Aggregate - {grades.Aggregate(20, (biggest, next) => next > biggest ? next : biggest)}");
		}

		static void QuantifiersMethod(List<Post> posts)
		{
            Console.WriteLine("QuantifiersMethod example:");
            Console.WriteLine($"Contains - {posts.Contains(posts.First())}");
			Console.WriteLine($"Any - {posts.Any(p => p.Topic.StartsWith("N"))}");
			Console.WriteLine($"All - {posts.All(p => p.Topic.StartsWith("S"))}");

			List<string> list1 = new List<string>() { "1", "2", "3", "c" };
			List<string> list2 = new List<string>() { "a", "b", "c" };
			Console.WriteLine($"SequenceEqual - {list1.SequenceEqual(list2)}");
        }

		static void ElementOperators(List<Post> posts)
		{
			Console.WriteLine("ElementOperators:");
			Console.WriteLine($"First - {posts.First(p => p.Topic.StartsWith("N")).Topic}");
			var result1 = posts.FirstOrDefault(p => p.Topic.StartsWith("Z"));
			if (result1 == null)
			{
				Console.WriteLine("FirstOrDefault - Null");
			}
			else
			{
				Console.WriteLine($"FirstOrDefault - {result1.Topic}");
			}

			Console.WriteLine($"Last - {posts.Last(p => p.Topic.StartsWith("N")).Topic}");
			var result2 = posts.LastOrDefault(p => p.Topic.StartsWith("Z"));
			if (result2 == null)
			{
				Console.WriteLine("LastOrDefault - Null");
			}
			else
			{
				Console.WriteLine($"LastOrDefault - {result2.Topic}");
			}


			List<Post> posts1 = new List<Post> { posts[0] };
			Console.WriteLine($"Single - {posts1.Single().Topic}");
			posts1 = new List<Post> { posts[2] };
			Console.WriteLine($"SingleOrDefault - {posts1.SingleOrDefault().Topic}");

			Console.WriteLine($"ElementAt - {posts.ElementAt(4).Topic}");
			Console.WriteLine($"ElementAtOrDefault - {posts.ElementAtOrDefault(3).Topic}");

			posts1 = new List<Post>();
			Console.WriteLine($"DefaultIfEmpty - {posts1.DefaultIfEmpty().GetType().Name}");

		}

		static void GenerationOperators()
		{
			var empty = Enumerable.Empty<string>();

			var repeat = Enumerable.Repeat(new Post(), 6);

			var range = Enumerable.Range(1, 20);
		}
	}
}
