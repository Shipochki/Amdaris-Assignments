namespace Assignment_Creational_Design_Patterns
{
	using Assignment_Creational_Design_Patterns.Products.Coffe;
	using Assignment_Creational_Design_Patterns.Products.Milk;

	public class CoffeeFactory
	{
		public void Run()
		{
			CoffeeMaker maker = new CoffeeMaker();
			Cappuccino cappuccino = new Cappuccino();

			maker.AddExtraSugar(cappuccino, 3);
			maker.AddExtraMilk(cappuccino, new SoyMilk());
			maker.MakeCoffee(cappuccino);

			Espresso espresso = new Espresso();
			maker.AddExtraSugar(espresso, 4);
			maker.MakeCoffee(espresso);

            Console.WriteLine(maker.ServeCoffees());
        }
	}
}
