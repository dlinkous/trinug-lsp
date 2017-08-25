using System;

namespace Liskov.Vehicles
{
	public class DodgeChallengerCar : Car
	{
		private int gas;

		public override void AddGas(int gallons) => gas += gallons;
	}
}
