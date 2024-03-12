using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Classes_in_C_Sharp
{
	public class Tesla : Vehicle
	{
		public Tesla(string brand, string model, Engine engine, bool isNew = true) : base(brand, model, engine, isNew)
		{
		}
	}
}
