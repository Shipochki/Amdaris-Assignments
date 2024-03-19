
using Class_Diagram;

namespace OPP_Fundamentals_Class_Diagram
{
	public class Vehicle
	{
		public int Id { get; set; }

		public string Brand { get; set; } = null!;

		public string Model { get; set; } = null!;

		public int Year { get; set; }

		public Fuel Fuel { get; set; }

		public int CreatorId { get; set; }

		public User User { get; set; } = null!;

		public int SeatCount { get; set; }

		public string? PictureLink { get; set; }

		public bool ACSystem { get; set; }
	}
}