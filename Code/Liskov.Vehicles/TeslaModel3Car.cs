using System;

namespace Liskov.Vehicles
{
	public class TeslaModel3Car : Car
	{
		public override void AddGas(int gallons)
		{
			throw new NotSupportedException();
		}
	}
}
