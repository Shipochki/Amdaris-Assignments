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
		private bool _isNew;

		protected Vehicle(string brand, string model, Engine engine, bool isNew = true)
		{
			if(engine is null)
			{
				throw new ArgumentNullException("Engine can't be null");
			}

			this._brand = brand;
			this._model = model;
			this._engine = engine;
			this._isNew = isNew;
		}

		public int FuelCapacity
		{
			get {  return this._fuelCapacity; }
		}

		public void Load(int amount)
		{
			this._fuelCapacity += amount;
		}

		public void Load()
		{
			if (this._engine.Fuel == "EV")
			{
				Console.WriteLine($"{this._brand} {this._model} is Charging");
				this._fuelCapacity = 100;
			}
		}

		public void Info()
		{
			Console.WriteLine($"Brand: {this._brand} - Model: {this._model}. Is new: {this._isNew}");
		}
	}
}
