namespace Assignment_Creational_Design_Patterns.Products.Coffe
{
	using Assignment_Creational_Design_Patterns.Products.Milk;

	public class Cappuccino : ICoffee
	{
        public Cappuccino()
        {
			BlackCoffee = 1;
			CubesSugar = 0;
			Milk = new List<IMilk> { new RegularMilk() };
        }
        public int BlackCoffee { get; set; }
		public int CubesSugar { get; set; }
		public List<IMilk> Milk { get; set; }
	}
}
