namespace Assignment_Creational_Design_Patterns.Products.Coffe
{
	using Assignment_Creational_Design_Patterns.Products.Milk;

	internal class FlatWhite : ICoffee
	{
		public int AmountBlackCoffee { get; set; }
		public int AmountSugar { get; set; }
		public List<IMilk> Milk { get; set; } = new List<IMilk>();
	}
}
