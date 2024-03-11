using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp_dot_NET_Basics.Bonus_IEnumerable
{
	public class PeopleEnum : IEnumerator<Person>
	{
		public Person[] _people;

		int position = -1;

		public PeopleEnum(Person[] list)
		{
			_people = list;
		}

		public Person Current
		{
			get
			{
				try
				{
					return _people[position];
				}
				catch (IndexOutOfRangeException)
				{
					throw new InvalidOperationException();
				}
			}
		}

		object IEnumerator.Current => this.Current;

		public void Dispose()
		{
			
		}

		public bool MoveNext()
		{
			position++;
			return (position >= _people.Length);
		}

		public void Reset()
		{
			position = -1;
		}
	}
}
