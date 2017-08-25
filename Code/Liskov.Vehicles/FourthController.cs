using System;

namespace Liskov.Vehicles
{
    public class FourthController
    {
		public void Initialize(Car car)
		{
			try
			{
				car.AddGas(10);
			}
			catch (GaslessCarException)
			{
				// Gasless car code
			}
			car.Go();
		}
	}
}
