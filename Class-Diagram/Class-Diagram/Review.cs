using Class_Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Fundamentals_Class_Diagram
{
	public class Review
	{
		public int Id { get; set; }

		public int CreatorId { get; set; }

		public User Creator { get; set; } = null!;

		public int Rating { get; set; }

		public string? Text { get; set; }

		public int UserId { get; set; }

		public User User { get; set; } = null!;

		public bool IsActive { get; set; }
	}
}
