using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFallCalculator
{
	internal class FreeFallCalculator
	{
		static double EarthG = 9.81;
		static double MoonG = 0.166;
		static double MarsG = 3.7;

		static void Main(string[] args)
		{
			Console.WriteLine("write the height");
			double height = Convert.ToDouble(Console.ReadLine());

			double Earth = FreeFallEarth(height);
			double Mars = FreeFallMars(height);
			double Moon = FreeFallMoon(height);

			Console.WriteLine($"Earth: {Earth} , Mars: {Mars} , Moons: {Moon}");
			Console.ReadLine();
		}

		static double FreeFallEarth(double height)
		{
			double timeToFall = Math.Sqrt((2 * height) / EarthG); // colculate the time
			return timeToFall;
		}

		static double FreeFallMoon(double height)
		{
			double timeToFall = Math.Sqrt((2 * height) / MoonG);
			return timeToFall;
		}

		static double FreeFallMars(double height)
		{
			double timeToFall = Math.Sqrt((2 * height) / MarsG);
			return timeToFall;
		}
	}
}
