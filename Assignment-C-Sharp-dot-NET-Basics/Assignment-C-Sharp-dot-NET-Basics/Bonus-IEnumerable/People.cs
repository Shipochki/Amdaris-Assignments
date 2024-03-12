using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp_dot_NET_Basics.Bonus_IEnumerable
{
	public class People : IEnumerable
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

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public PeopleEnum GetEnumerator()
		{
			return new PeopleEnum(_people);
		}
	}
}
