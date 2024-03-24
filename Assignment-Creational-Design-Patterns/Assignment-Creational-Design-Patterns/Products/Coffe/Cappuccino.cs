namespace Assignment_Creational_Design_Patterns.Products.Coffe
{
	using Assignment_Creational_Design_Patterns.Products.Milk;

	public class Cappuccino : ICoffe
	{
		public int AmountBlackCoffe { get; set; }
		public int AmountSugar { get; set; }
		public List<IMilkType> Milk { get; set; } = new List<IMilkType>();
	}
}
