namespace Assignment_Arrays_collections_generics
{
	using Assignment_Arrays_collections_generics.Entities;
	using Assignment_Arrays_collections_generics.Repository;
	using static Assignment_Arrays_collections_generics.Common.Infrastructure;

	public class Program
	{
		static void Main(string[] args)
		{
			Repository<User> userRepository = LoadUsers();
			Repository<Post> postRepository = new Repository<Post>();

			BusinessLogic logic = new BusinessLogic(userRepository, postRepository);
			Post post = new Post() { Id = 1, Topic = "Sport", Description = "The best sport is ...", CreatorId = 1 };
			logic.PublishingPost(1, post);
			logic.PublishingPost(2, new Post { Id = 2, Topic = "News", Description = "Sky is blue", CreatorId = 2 });
			logic.PublishingPost(3, new Post { Id = 3, Topic = "Space", Description = "SpaceX launch rocket", CreatorId = 3 });
			logic.PublishingPost(1, new Post { Id = 1, Topic = "Fantasy", Description = "The best fantasy is ...", CreatorId = 1 });

            Console.WriteLine();
            logic.PublishingPost(1, null);
			logic.PublishingPost(6, post);

            Console.WriteLine();
            logic.RemovePost(3);
			logic.RemovePost(5);

            Console.WriteLine();
            post.Topic = "SportUpdate";
			logic.UpdatePost(post);
			logic.UpdatePost(null);
			logic.UpdatePost(new Post() { Id = 4, Topic = "Test", Description = "Test description", CreatorId = 2 });

			List<Post> posts = logic.GetAllPosts();
            Console.WriteLine();
            PrintPosts(posts);

			PrintPostsByUser(logic, 1);
		}

		static void PrintPosts(List<Post> posts)
		{
            Console.WriteLine("Posts:");

			foreach (var post in posts)
			{
				Console.WriteLine($"{post.Topic} : {post.Description}");
			}
		}

		static void PrintPostsByUser(BusinessLogic logic, int userId)
		{
			Console.WriteLine();
			List<Post> postsByUser = logic.GetAllPostsByCreatorId(userId);
			User user = logic.GetPublisherById(userId);
			Console.WriteLine($"Posts by {user.Name}");

			PrintPosts(postsByUser);
		}
	}
}
