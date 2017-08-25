using System;

namespace Liskov.Vehicles
{
    public abstract class Car
    {
		public abstract void AddGas(int gallons);

		public void Go() { }
    }
}
