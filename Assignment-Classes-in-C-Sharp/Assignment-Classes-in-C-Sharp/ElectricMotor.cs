using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Classes_in_C_Sharp
{
	public class ElectricMotor : Engine
	{
		public ElectricMotor(int horsepower, string fuel) : base(horsepower, fuel)
		{
		}

		protected override string Type()
		{
			return "This is a Electric Engine";
		}
	}
}
