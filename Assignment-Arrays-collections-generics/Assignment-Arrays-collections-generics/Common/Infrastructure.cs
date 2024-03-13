using Assignment_Arrays_collections_generics.Entities;
using Assignment_Arrays_collections_generics.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Arrays_collections_generics.Common
{
	public static class Infrastructure
	{
		public static Repository<User> LoadUsers()
		{
			Repository<User> users = new Repository<User>();

			users.Add(new User { Id = 1, Name = "Pesho" });
			users.Add(new User { Id = 2, Name = "Mitko" });
			users.Add(new User { Id = 3, Name = "Ivan" });
				
			return users;
		}

		public static Repository<Post> LoadPosts()
		{
			Repository<Post> posts = new Repository<Post>();

			posts.Add(new Post { Id = 1, Topic = "Sport", Description = "The best sport is ..." });
			posts.Add(new Post { Id = 2, Topic = "Space", Description = "SpaceX launch rocket" });
			posts.Add(new Post { Id = 3, Topic = "News", Description = "Sky is blue" });

			return posts;
		}
	}
}
