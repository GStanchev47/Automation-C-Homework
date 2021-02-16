using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_3___Arrays
{
	public class Task_6
	{
		public void SixthTask()
		{
			int[] intArray = new int[7] { 2, 3, 8, 1, 6, 15, 9 };

			Array.Sort(intArray);

			Console.WriteLine("The second largest number in the array is: " + intArray[intArray.Length - 2]);
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");
			Console.WriteLine();
		}

	}
}
