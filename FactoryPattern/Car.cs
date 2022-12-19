using System;
namespace FactoryPattern
{
	public class Car : IVehicle
	{
		public Car()
		{
		}

		public void Drive()
		{
			Console.WriteLine("this Car is now in Drive. Woooo");
		}

	}
}

