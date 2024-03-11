using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp_dot_NET_Basics.Bonus_ICloneable
{
	public class Person : ICloneable
	{
		public IdInfo IdInfo { get; set; }

		public int Age { get; set; }

		public string Name { get; set; }

		public List<Address> Addresses { get; set; } = new List<Address>();

		public object Clone()
		{
			Person clonedPerson = (Person)this.MemberwiseClone();

			clonedPerson.IdInfo = new IdInfo
			{
				IdNumber = IdInfo.IdNumber,
			};

			clonedPerson.Addresses = new List<Address>();
			foreach(Address address in Addresses)
			{
				Address cloneAddress = (Address)address.Clone();

				clonedPerson.Addresses.Add(cloneAddress);
			}

			return clonedPerson;
		}
	}
}
