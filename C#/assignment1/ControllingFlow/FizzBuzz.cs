﻿using System;
namespace ControllingFlow
{
	public class FizzBuzz
	{
		public void Count()
		{
			for (int i=0;i<100;i++)
            {
				if (i%3==0 && i%5==0) {
					Console.WriteLine("fizzbuzz");
				}
				else if (i%3==0) {
					Console.WriteLine("fizz");
                }
				else if (i%5==0) {
					Console.WriteLine("buzz");
                }
				else
                {
					Console.WriteLine(i);
                }
            }
		}
	}
}

