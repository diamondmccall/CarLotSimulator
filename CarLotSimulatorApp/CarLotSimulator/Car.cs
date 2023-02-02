using System;
namespace CarLotSimulator
{
	public class Car
	{

		public Car()
		{

		}
		public Car(int year, string make, string model, string engineNoise, string honkNoise, string isDriveable)

		{
			Year = year;
			Make = make;
			Model = model;
			EngineNoise = engineNoise;
			HonkNoise = honkNoise;
			IsDriveable = isDriveable;
		}
		
		public string Make { get; set; }
		public int Year { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public string IsDriveable { get; set; }

		public void MakeEngineNoise(string EngineNoise)
		{
			Console.WriteLine($"{EngineNoise}");
		}
		public void MakeHonkingNoise(string HonkingNoise)
		{
			Console.WriteLine($"{HonkNoise}");
		}
    }
}

