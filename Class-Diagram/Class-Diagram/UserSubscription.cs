using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Diagram
{
	public class UserSubscription
	{
		public int Id { get; set; }

		public int UserId { get; set; }

		public User User { get; set; } = null!;

		public bool IsPaid { get; set; }

		public DateTime DateTimePaid { get; set; }

		public bool IsAutomaticallyPaid { get; set; }
	}
}