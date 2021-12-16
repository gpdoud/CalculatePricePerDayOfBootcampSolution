using System;

namespace CalculatePricePerDayOfBootcamp
{
	class Program
	{
		static void Main(string[] args)
		{
			var CostOfBootcamp = 15500m;
			var NumberOfDays = 65;
			var PricePerDay = CostOfBootcamp / NumberOfDays;
			var PreMessage = "The boot camp costs ";
			var PostMessage = " per day.";
			var Message = $"{PreMessage}{PricePerDay}{PostMessage}";
			Console.WriteLine($"{Message}");
			System.Diagnostics.Debug.WriteLine($"{Message}");
		}
	}
}
