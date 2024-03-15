#define STAGE

using Assignment_Debugging_And_Exception_Handling.CustomExceptions;

namespace Assignment_Debugging_And_Exception_Handling
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<Car> cars = LoadCars();

			Adding(cars);

			Removing(cars);

#if (STAGE)

			PrintCarCollection(cars);

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


		/// <summary>
		/// Presents add functionality
		/// </summary>
		/// <param name="cars"></param>
		public static void Adding(List<Car> cars)
		{
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
			}
			catch (CarCollectionException m)
			{
				Console.WriteLine(m.Message);
				throw;
			}
			finally
			{
				if(cars.FirstOrDefault(c => c.Brand == car.Brand) != null)
				{
                    Console.WriteLine("Successfully added Car!");
                }
			}
		}


		/// <summary>
		/// Present delete functionality
		/// </summary>
		/// <param name="cars"></param>
		public static void Removing(List<Car> cars)
		{
			Car car = new Car() { Brand = "Seat", Model = "Leon", Color = "Yellow" };

			try
			{
				//RemoveCar(cars.First().Brand, cars);
				//RemoveCar(car.Brand, cars);
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
				if (cars.FirstOrDefault(c => c.Brand == car.Brand) == null)
				{
					Console.WriteLine("Successfully removed Car!");
				}
			}
		}


		/// <summary>
		/// Functionality for adding car in cars 
		/// </summary>
		/// <param name="car"></param>
		/// <param name="cars"></param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="CarCollectionException"></exception>
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


		/// <summary>
		/// Functionality for deleting car with matching brand in cars
		/// </summary>
		/// <param name="brand"></param>
		/// <param name="cars"></param>
		/// <exception cref="CarCollectionException"></exception>
		/// <exception cref="RemoveCarException"></exception>
		public static void RemoveCar(string brand, List<Car> cars)
		{
			if (cars == null)
			{
				throw new CarCollectionException("Car collection can't be null");
			}

			Car? result = cars.FirstOrDefault(c => c.Brand == brand);

			if (result == null)
			{
				throw new RemoveCarException($"Can't find car with this Brand: {brand}");
			}

			cars.Remove(result);
		}


		/// <summary>
		/// Method for printing collection of cars
		/// </summary>
		/// <param name="cars"></param>
		public static void PrintCarCollection(List<Car> cars)
		{
			try
			{
				foreach (var car in cars)
				{
					Print(car);
					//Print(null);
				}
			}
			catch (ArgumentNullException m)
			{
				Console.WriteLine(m.Message);
				throw;
			}

		}

		public static void Print(Car car)
		{
			if (car == null)
			{
				throw new ArgumentNullException($"In Print method car is null");
			}

			Console.WriteLine($"{car.Brand} {car.Model} {car.Color}");
		}
	}
}
