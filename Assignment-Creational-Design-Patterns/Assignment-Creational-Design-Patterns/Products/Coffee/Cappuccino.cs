namespace Assignment_Creational_Design_Patterns.Products.Coffe
{
	using Assignment_Creational_Design_Patterns.Products.Milk;

	public class Cappuccino : ICoffee
	{
        public Cappuccino()
        {
			AmountBlackCoffee = 1;
			AmountSugar = 0;
			Milk = new List<IMilk> { new RegularMilk() };
        }
        public int AmountBlackCoffee { get; set; }
		public int AmountSugar { get; set; }
		public List<IMilk> Milk { get; set; }
	}
}
