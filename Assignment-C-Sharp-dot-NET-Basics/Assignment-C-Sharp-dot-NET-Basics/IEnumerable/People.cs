using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp_dot_NET_Basics.IEnumerable
{
	public class People : IEnumerable<Person>
	{
		private Person[] _people;

        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                this._people[i] = pArray[i];
            }
        }

		public IEnumerator<Person> GetEnumerator()
		{
			return new PeopleEnum(_people);
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
