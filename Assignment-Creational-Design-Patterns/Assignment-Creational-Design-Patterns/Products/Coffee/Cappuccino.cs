namespace Assignment_Creational_Design_Patterns.Products.Coffe
{
	using Assignment_Creational_Design_Patterns.Products.Milk;

	public class Cappuccino : ICoffee
	{
		public int AmountBlackCoffee { get; set; }
		public int AmountSugar { get; set; }
		public List<IMilk> Milk { get; set; } = new List<IMilk>();
	}
}
