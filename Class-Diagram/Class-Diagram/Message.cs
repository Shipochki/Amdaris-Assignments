using Class_Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Fundamentals_Class_Diagram
{
	public class Message
	{
		public int Id { get; set; }

		public string Text { get; set; } = null!;

		public int CreatorId { get; set; }

		public User Creator { get; set; } = null!;

		public int GroupId { get; set; }

		public Group Group { get; set; } = null!;

		public DateTime CreatedOn { get; set; }

		public DateTime UpdatedOn { get; set; }

		public DateTime DeletedOn { get; set; }

		public bool IsActive { get; set; }
	}
}
