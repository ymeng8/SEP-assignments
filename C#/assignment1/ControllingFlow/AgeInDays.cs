using System;
namespace ControllingFlow
{
	public class AgeInDays
	{
		public string Birthdate { get; set; }
		
		public void Calculate()
        {
			string[] split = Birthdate.Split("/");
			int year = int.Parse(split[0]), month = int.Parse(split[1]), day = int.Parse(split[2]);
			int tyear = DateTime.Now.Year, tmonth = DateTime.Now.Month, tday = DateTime.Now.Day;
			
			int days = 0;
			int[] month31 = { 1, 3, 5, 7, 8, 10, 12 };

			for (int i=year+1; i<tyear; i++)
            {
				if (i%4==0) { days += 366; }
				else { days += 365; }
            }

			for (int i=month+1; i<=12; i++)
            {
				if (month31.Contains(i)) { days += 31; }
				else if (i==2)
                {
					if (year%4==0) { days += 29; }
					else { days += 28; }
                }
				else { days += 30; }
            }

			if (month31.Contains(month)) { days += 31 - day; }
			else { days += 30 - day; }

			for (int i = 1; i < tmonth; i++)
			{
				if (month31.Contains(i)) { days += 31; }
				else if (i == 2)
				{
					if (tyear % 4 == 0) { days += 29; }
					else { days += 28; }
				}
				else { days += 30; }
			}

			days += tday;

			Console.WriteLine($"Your age in days is {days} days.");
		}
	}
}

