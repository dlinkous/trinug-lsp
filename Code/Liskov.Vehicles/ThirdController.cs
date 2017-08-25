using System;

namespace Liskov.Vehicles
{
    public class ThirdController
    {
		public void Initialize(Car car)
		{
			try
			{
				car.AddGas(10);
			}
			catch (NotSupportedException)
			{
				// Gasless car code
			}
			car.Go();
		}
	}
}
