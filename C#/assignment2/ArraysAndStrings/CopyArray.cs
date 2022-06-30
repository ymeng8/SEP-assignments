using System;
namespace ArraysAndStrings
{
	public class CopyArray
	{
		public void Run()
		{
			int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
			int[] arr2 = new int[arr.Length];

			for (int i = 0; i < arr.Length; i++) { arr2[i] = arr[i]; }
			Console.WriteLine($"Array1: {String.Join(", ", arr)}");
			Console.WriteLine($"Array2: {String.Join(", ", arr2)}");
		}
	}
}

