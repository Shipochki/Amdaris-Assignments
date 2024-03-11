using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp_dot_NET_Basics.Bonus_ICloneable
{
	public class Address : ICloneable
	{
		public string Street { get; set; }

		public object Clone()
		{
			return this.MemberwiseClone();
		}
	}
}
