using System;
namespace ArraysAndStrings
{
	public static class FindPrime
	{
		public static int[] FindPrimesInRange(int startNum, int endNum)
        {
			List<int> ls = new List<int>();
			bool isPrime;

			for (int num = startNum; num <= endNum; num++)
            {
				isPrime = true;
				for (int i = 2; i < num; i++)
                {
					if (num % i == 0)
					{
						isPrime = false;
						break;
					}
                }
				if (isPrime) { ls.Add(num); }
            }

			return ls.ToArray();
        }
	}
}


