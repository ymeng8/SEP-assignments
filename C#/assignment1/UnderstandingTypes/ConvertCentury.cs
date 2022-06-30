using System;
namespace UnderstandingTypes
{
	public class ConvertCentury
	{
		public void OutputCentury()
		{
			int centuries, years;
			long days, hours, min, sec, ms, us, ns;

			Console.WriteLine("Enter a century:");
			centuries = Convert.ToInt32(Console.ReadLine());

			years = centuries * 100;
			days = years * 365; //365.25?
			hours = days * 24;
			min = hours * 60;
			sec = min * 60;
			ms = sec * 1000;
			us = ms * 1000;
			ns = us * 1000; //handle overflow?

			Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours " +
				$"= {min} minutes = {sec} seconds = {ms} milliseconds = {us} microseconds = {ns} nanoseconds");

		}
	}
}

