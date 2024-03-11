using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp_dot_NET_Basics.AnimalHierarchy
{
	public class Titmouse : Animal
	{
		protected override string Eat(int kg)
		{
			base.weight += kg;
			if (weight < 1)
			{
				return "Chuby";
			}
			else
			{
				return "Normal";
			}
		}

		public string Eat(int kg, string type)
		{
			string result = Eat(kg);

			if(type == "Bred")
			{
				return $"Mmm {type} {result}";
			}
			else
			{
				return "Don't liked";
			}
		}

		protected override string Talk()
		{
			return "Pew Pew";
		}
	}
}
