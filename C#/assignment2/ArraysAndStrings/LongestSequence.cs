using System;
namespace ArraysAndStrings
{
	public class LongestSequence
	{
		public void Run(int[] arr)
		{
			int length = 0;
			int elem = 0;
			int i = 0, j = 0;

			while (j < arr.Length)
            {
				while (j<arr.Length-1 && arr[j + 1] == arr[j])
                {
					j++;
                }
				if (j - i + 1 > length)
				{
					length = j - i + 1;
					elem = arr[i];
				}
				j++;
				i = j;
            }

			for (int x=0; x < length; x++)
            {
				Console.Write(elem + " ");
            }
        }
	}
}

