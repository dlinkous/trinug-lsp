using System;

namespace Liskov.Vehicles
{
    public class FirstController
    {
		public void Initialize(Car car)
		{
			car.AddGas(10);
			car.Go();
		}
    }
}
