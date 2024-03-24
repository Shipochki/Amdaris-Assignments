namespace Assignment_Creational_Design_Patterns
{
	using Assignment_Creational_Design_Patterns.Products.Coffe;

	public interface ICoffeMaker
	{
		public void MakeCoffe(ICoffee coffee);

		public string ServeCoffees();
	}
}
