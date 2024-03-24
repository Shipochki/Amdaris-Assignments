namespace Assignment_Creational_Design_Patterns.Products.Coffe
{
	using Assignment_Creational_Design_Patterns.Products.Milk;

	public class FlatWhite : ICoffee
	{
        public FlatWhite()
        {
			AmountBlackCoffee = 2;
			AmountSugar = 0;
			Milk = new List<IMilk>();
        }

        public int AmountBlackCoffee { get; set; }
		public int AmountSugar { get; set; }
		public List<IMilk> Milk { get; set; }
	}
}
