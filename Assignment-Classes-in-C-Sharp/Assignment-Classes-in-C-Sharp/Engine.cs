using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Classes_in_C_Sharp
{
	public abstract class Engine
	{
		private int _horsepower;
		private string _fuel;

        public Engine(int horsepower, string fuel)
        {
            this._horsepower = horsepower;
            this._fuel = fuel;
        }

        public int HorsePower { get { return _horsepower; } }

        public string Fuel { get { return _fuel;} }

        protected abstract string Type();
    }
}
