using Assignment_C_Sharp_dot_NET_Basics.Bonus_IEnumerable;

namespace Assignment_C_Sharp_dot_NET_Basics
{
	public class Program
	{
		static void Main(string[] args)
		{
			Person[] peopleArray = new Person[3]
		{
			new Person("John", "Smith"),
			new Person("Jim", "Johnson"),
			new Person("Sue", "Rabon"),
		};

			People peopleList = new People(peopleArray);
			foreach (Person p in peopleList)
				Console.WriteLine(p.FirstName + " " + p.LastName);
		}
	}
}