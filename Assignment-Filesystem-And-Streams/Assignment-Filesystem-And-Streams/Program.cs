namespace Assignment_Filesystem_And_Streams
{
	using static Assignment_Filesystem_And_Streams.DriversInfo;
	using static Assignment_Filesystem_And_Streams.FileSystemInformation;

	internal class Program
	{
		static readonly Logger.Logger logger = new Logger.Logger();
		static List<Post> posts = new List<Post>();

		static void Main(string[] args)
		{
			//GetInformationAboutDrivers();
			//GetInformationAboutFileSystem();

			try
			{
				//AddPost(new Post() { Id = 1, Name = "News" });
				AddPost(null);
			}
			catch (ArgumentNullException m)
			{
				logger.Log(m.Message);
			}

			logger.Read();
		}

		static void AddPost(Post post)
		{
			if(post == null)
			{
				throw new ArgumentNullException(MessageTemplete(message: "post is null", methodName: "AddPost"));
			}

			posts.Add(post);

			logger.Log(MessageTemplete(message: "Succesful added post in collection posts", methodName: "AddPost"));
		}

		static string MessageTemplete(string message, string methodName)
		{
			return $"Method name: {methodName} - DateTime: {DateTime.UtcNow} - {message}";
		}
	}
}
