using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp_dot_NET_Basics.AnimalHierarchy
{
	public abstract class Animal
	{
		protected int weight;
		protected abstract string Eat(int kg);
        protected abstract string Talk();
	}
}
