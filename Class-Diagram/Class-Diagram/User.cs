using OPP_Fundamentals_Class_Diagram;

namespace Class_Diagram
{
	public class User
	{
		public int Id { get; set; }

		public string FirstName { get; set; } = null!;

		public string LastName { get; set; } = null!;

		public string PhoneNumber { get; set; } = null!;

		public string Country { get; set; } = null!;

		public string City { get; set; } = null!;

		public string Email { get; set; } = null!;

		public bool IsEmailConfirmed { get; set; }

		public int VerificationEmailId { get; set; }

		public VerificationEmail VerificationEmail { get; set; } = null!;

		public bool IsVerified { get; set; }

		public string PasswordHashed { get; set; } = null!;

		public string? PictureLink { get; set; }

		public int? VehicleId { get; set; }

		public Vehicle? Vehicle { get; set; }

		public Role Role { get; set; } = null!;

		public List<Review> Reviews { get; set; } = new List<Review>();

		public List<Message> Messages { get; set; } = new List<Message>();

		public List<UserGroup> UsersGroups { get; set; } = new List<UserGroup>();

		public List<Post> Posts { get; set; } = new List<Post>();

		public DateTime CreatedOn { get; set; }

		public DateTime UpdatedOn { get; set; }

		public DateTime DeletedOn { get; set; }

		public bool IsActive { get; set; }
	}
}