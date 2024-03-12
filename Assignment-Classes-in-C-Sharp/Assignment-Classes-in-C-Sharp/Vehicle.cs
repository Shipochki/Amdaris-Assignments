using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Classes_in_C_Sharp
{
	public abstract class Vehicle
	{
		private string _brand;
		private string _model;
		private Engine _engine;
		private int _fuelCapacity;

        protected Vehicle(string brand, string model, Engine engine)
        {
			this._brand = brand;
            this._model = model;
			this._engine = engine;
        }

        public int FuelCapacity { get; set; }
    }
}
