using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_3___Arrays
{
	public class Task_5
	{
		public void FifthTask()
		{
			int[] intArray = new int[7] { 2, 3, 8, 1, 6, 15, 9 };
			Array.Clear(intArray, 2, 1);

			foreach (int number in intArray)
			{
				Console.WriteLine(number);
			}

			
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");
			Console.WriteLine();
		}
	}
}
