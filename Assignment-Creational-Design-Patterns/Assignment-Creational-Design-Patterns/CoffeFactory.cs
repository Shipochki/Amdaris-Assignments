namespace Assignment_Creational_Design_Patterns
{
	using Assignment_Creational_Design_Patterns.Products.Coffe;
	using Assignment_Creational_Design_Patterns.Products.Milk;

	public class CoffeFactory
	{
		public void Run()
		{
			CoffeMaker maker = new CoffeMaker();
			Cappuccino cappuccino = new Cappuccino();

			maker.AddExtraSugar(cappuccino, 3);
			maker.AddExtraMilk(cappuccino, new SoyMilk());


		}
	}
}
