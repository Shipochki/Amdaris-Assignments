namespace Assignment_Creational_Design_Patterns
{
	using Assignment_Creational_Design_Patterns.Products.Coffe;
	using Assignment_Creational_Design_Patterns.Products.Milk;

	public interface ICoffeMaker
	{
		public void MakeCoffee(ICoffee coffee);

		public void AddExtraSugar(ICoffee coffee, int amountSugar);

		public void AddExtraMilk(ICoffee coffee, IMilk milk);

		public string ServeCoffees();
	}
}
