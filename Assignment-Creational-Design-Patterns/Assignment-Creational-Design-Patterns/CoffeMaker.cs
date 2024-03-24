using Assignment_Creational_Design_Patterns.Products.Coffe;

namespace Assignment_Creational_Design_Patterns
{
	public class CoffeMaker : ICoffeMaker
	{
		private readonly List<ICoffee> coffee;

        public CoffeMaker()
        {
            coffee = new List<ICoffee>();
        }

        public void MakeCoffe(ICoffee coffee)
		{
			string nameOfCoffee = nameof(coffee);

			if(nameOfCoffee == nameof(Cappuccino))
			{

			}
			else if(nameOfCoffee == nameof(Espresso))
			{

			}
			else if(nameOfCoffee == nameof(FlatWhite))
			{

			}
			else
			{

			}
		}

		public string ServeCoffees()
		{
			throw new NotImplementedException();
		}
	}
}
