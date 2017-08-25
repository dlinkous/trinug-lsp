using System;

namespace Liskov.Vehicles
{
    public class NissanLeafCar : Car
    {
		public override void AddGas(int gallons)
		{
			throw new GaslessCarException();
		}
	}
}
