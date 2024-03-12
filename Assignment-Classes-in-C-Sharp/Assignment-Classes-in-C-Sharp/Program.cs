namespace Assignment_Classes_in_C_Sharp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			V6Engine v6Engine = new V6Engine(250, "Gasoline");
			Ferrari ferrari = new Ferrari("Ferarri", "Spider", v6Engine, false);

			ferrari.Load(amount: 10);
            Console.WriteLine(ferrari.FuelCapacity);
			ferrari.Info();

			if(ferrari as Vehicle != null)
			{
                Console.WriteLine("Ferrari is not null");
            }

			ElectricMotor electricMotor = new ElectricMotor(650, "EV");
			Tesla tesla = new Tesla("Tesla", "S", electricMotor);

			tesla.Load();
			tesla.Info();
        }
	}
}
