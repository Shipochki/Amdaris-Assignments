namespace Assignment_Creational_Design_Patterns.Products.Coffe
{
	using Assignment_Creational_Design_Patterns.Products.Milk;

	public class Espresso : ICoffee
	{
        public Espresso()
        {
			BlackCoffee = 1;
			CubesSugar = 0;
			Milk = new List<IMilk>();
        }

        public int BlackCoffee { get; set; }
		public int CubesSugar { get; set; }
		public List<IMilk> Milk { get; set; }
	}
}
