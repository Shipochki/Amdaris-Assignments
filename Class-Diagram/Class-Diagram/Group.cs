using Class_Diagram;
namespace OPP_Fundamentals_Class_Diagram
{
	public class Group
	{
		public int Id { get; set; }

		public int PostId { get; set; }

		public Post Post { get; set; } = null!;

		public int CreatorId { get; set; }

		public User Creator { get; set; } = null!;

		public bool IsActive { get; set; }

		public List<UserGroup> UsersGroups { get; set; } = new List<UserGroup>();

		public List<Message> Messages { get; set; } = new List<Message>();
	}
}
