﻿namespace Assignment_Behavioral_Design_Patterns.Entities
{
	using Assignment_Behavioral_Design_Patterns.Enums;

	public class Order()
	{
		public int Id { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();

		public Status Status { get; set; }
    };
}
