#define STAGE

using Assignment_Debugging_And_Exception_Handling.CustomExceptions;

namespace Assignment_Debugging_And_Exception_Handling
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<Car> cars = LoadCars();

			Car car = new Car() { Brand = "Seat", Model = "Leon", Color = "Yellow" };

			try
			{
				//AddCar(car, cars);
				//AddCar(null, cars);
				//AddCar(car, null);
			}
			catch (ArgumentNullException m)
			{
				Console.WriteLine(m.Message);
				throw;
			}
			catch (CarCollectionException m)
			{
				Console.WriteLine(m.Message);
				throw;
			}
			finally
			{
				Console.WriteLine("Finally Add Car");
			}

			try
			{
				//RemoveCar(cars.First(), cars);
				//RemoveCar(string.Empty, cars);
				//RemoveCar(car, cars);
			}
			catch (CarCollectionException m)
			{
				Console.WriteLine(m.Message);
				throw;
			}
			catch (RemoveCarException m)
			{
				Console.WriteLine(m.Message);
				throw;
			}
			finally
			{
				Console.WriteLine("Finally Remove Car");
			}


#if (STAGE)
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Brand} {item.Model} {item.Color}");
            }
#endif
        }

		public static List<Car> LoadCars()
		{
			Car car = new Car()
			{
				Brand = "Mercedes",
				Model = "C-Class",
				Color = "Black"
			};

			Car car2 = new Car()
			{
				Brand = "BMW",
				Model = "5-Series",
				Color = "White"
			};

			Car car3 = new Car()
			{
				Brand = "VW",
				Model = "Golf 4",
				Color = "Blue"
			};

			return new List<Car> { car, car2, car3 };
		}

		public static void AddCar(Car car, List<Car> cars)
		{
			if (car == null)
			{
				throw new ArgumentNullException("Method: AddCar - car can't be null");
			}

			if (cars == null)
			{
				throw new CarCollectionException("Car collection can't be null");
			}

			cars.Add(car);
		}

		public static void RemoveCar(string brand, List<Car> cars)
		{
			if (cars == null)
			{
				throw new CarCollectionException("Car collection can't be null");
			}

			Car? result = cars.FirstOrDefault(c => c.Brand == brand);

			if(result == null)
			{
				throw new RemoveCarException("Can't find car with same Brand");
			}

			cars.Remove(result);
		}
	}
}
