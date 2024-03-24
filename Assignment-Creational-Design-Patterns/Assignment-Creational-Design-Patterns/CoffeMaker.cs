namespace Assignment_Creational_Design_Patterns
{
	using Assignment_Creational_Design_Patterns.Products.Coffe;
	using Assignment_Creational_Design_Patterns.Products.Milk;

	public class CoffeMaker : ICoffeMaker
	{
		private readonly List<ICoffee> coffees;

		public CoffeMaker()
		{
			this.coffees = new List<ICoffee>();
		}

		public void AddExtraMilk(ICoffee coffee, IMilk milk)
		{
			if(!IsValidCoffee(coffee))
			{
				throw new ArgumentException("Invalid Coffee");
			}

			if(!IsValidMilk(milk))
			{
				throw new ArgumentException("Invalid Milk");
			}

			coffee.Milk.Add(milk);
		}

		public void AddExtraSugar(ICoffee coffee, int amountSugar)
		{
			if (!IsValidCoffee(coffee))
			{
				throw new ArgumentException("Invalid Coffee");
			}

			coffee.AmountSugar += amountSugar;
		}

		public void MakeCoffee(ICoffee coffee)
		{
			if (!IsValidCoffee(coffee))
			{
				throw new ArgumentException("Invalid Coffee");
			}

			this.coffees.Add(coffee);
		}

		public string ServeCoffees()
		{
			return $"Serving: {string.Join(" ", this.coffees.Select(c => nameof(c)))}";
		}

		private bool IsValidCoffee(ICoffee coffee)
		{
			string nameOfCoffee = nameof(coffee);

			if (nameOfCoffee == nameof(FlatWhite)
				|| nameOfCoffee == nameof(Cappuccino)
				|| nameOfCoffee == nameof(Espresso))
			{
				return true;
			}

			return false;
		}

		private bool IsValidMilk(IMilk milk)
		{
			string nameOfMilk = (nameof(milk));

			if (nameOfMilk == nameof(OatMilk)
				|| nameOfMilk == nameof(RegularMilk)
				|| nameOfMilk == nameof(SoyMilk))
			{
				return true;
			}

			return false;
		}
	}
}
