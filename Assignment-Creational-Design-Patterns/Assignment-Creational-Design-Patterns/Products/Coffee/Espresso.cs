namespace Assignment_Creational_Design_Patterns.Products.Coffe
{
	using Assignment_Creational_Design_Patterns.Products.Milk;

	public class Espresso : ICoffee
	{
        public Espresso()
        {
			AmountBlackCoffee = 1;
			AmountSugar = 0;
			Milk = new List<IMilk>();
        }

        public int AmountBlackCoffee { get; set; }
		public int AmountSugar { get; set; }
		public List<IMilk> Milk { get; set; }
	}
}
