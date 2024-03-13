namespace Assignment_Arrays_collections_generics
{
	using Assignment_Arrays_collections_generics.Entities;
	using Assignment_Arrays_collections_generics.Repository;

	public class BusinessLogic
	{
		private readonly IRepository<User> _userRepository;
		private readonly IRepository<Post> _postRepository;

		public BusinessLogic(IRepository<User> userRepository, IRepository<Post> postRepository)
		{
			_userRepository = userRepository;
			_postRepository = postRepository;
		}

		public bool PublishingPost(int userId, Post post)
		{
			try
			{
				User user = _userRepository.GetById(userId);

				_postRepository.Add(post);

				Console.WriteLine($"Successful published post! Topic: {post.Topic} Publisher: {user.Name}");
				return true;
			}
			catch (ArgumentNullException m)
			{
				Console.WriteLine(m.Message);
				return false;
			}
		}

		public bool RemovePost(int postId)
		{
			try
			{
				_postRepository.Delete(postId);

				Console.WriteLine($"Successful removed post with Id {postId}");

				return true;
			}
			catch (ArgumentNullException m)
			{
				Console.WriteLine(m.Message);
				return false;
			}
		}

		public List<Post> GetAllPosts()
		{
			return (List<Post>)_postRepository.GetAll();
		}

		public List<Post> GetAllPostsByCreatorId(int creatorId)
		{
			return GetAllPosts().Where(p => p.CreatorId == creatorId).ToList();
		}

		public User GetPublisherById(int creatorId)
		{
			try
			{
				return _userRepository.GetById(creatorId);
			}
			catch (ArgumentNullException m)
			{
                Console.WriteLine(m.Message);
				return null;
			}
			
		}

		public bool UpdatePost(Post post)
		{
			try
			{
				_postRepository.Update(post);

                Console.WriteLine($"Succefuly update post {post.Topic}");
                return true;
			}
			catch (ArgumentNullException m)
			{
                Console.WriteLine(m.Message);
                return false;
			}
		}
	}
}
