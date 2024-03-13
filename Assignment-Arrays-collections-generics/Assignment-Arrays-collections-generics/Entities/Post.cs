namespace Assignment_Arrays_collections_generics.Entities
{
	public class Post : Entity
	{
		public string Topic { get; set; } = null!;

		public string Description { get; set; } = null!;

		public int CreatorId { get; set; }
	}
}
