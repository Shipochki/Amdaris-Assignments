namespace Assignment_Creational_Design_Patterns.Products.Coffe
{
	using Assignment_Creational_Design_Patterns.Products.Milk;

	public class FlatWhite : ICoffee
	{
        public FlatWhite()
        {
			BlackCoffee = 2;
			CubesSugar = 0;
			Milk = new List<IMilk>();
        }

        public int BlackCoffee { get; set; }
		public int CubesSugar { get; set; }
		public List<IMilk> Milk { get; set; }
	}
}
