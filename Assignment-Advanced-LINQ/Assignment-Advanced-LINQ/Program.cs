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
			List<Post> posts = new List<Post>() {  post1, post2, post3, post4 };

			JoinMethod(users, posts);
            Console.WriteLine();
            GroupJoinMethod(users, posts);
            Console.WriteLine();
        }

		static void JoinMethod(List<User> users, List<Post> posts)
		{
			var result = users.Join(posts,
				creator => creator,
				posts => posts.Creator,
				(creator, post) => new { CreatorName = creator.Name, PostName = post.Topic });

            Console.WriteLine("Join example");
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

            Console.WriteLine("GroupJoin example");
            foreach (var creator in result)
            {
                Console.WriteLine($"Creator: {creator.CreatorName}");
                foreach (var post in creator.Posts)
                {
                    Console.WriteLine($" - {post.Topic}");
                }
            }
        }
	}
}
