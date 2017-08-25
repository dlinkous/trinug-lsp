using System;

namespace Liskov.Vehicles
{
    public class SecondController
    {
		public void Initialize(Car car)
		{
			try
			{
				car.AddGas(10);
			}
			catch
			{
				// Gasless car code
			}
			car.Go();
		}
	}
}
