using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_3___Arrays
{
	public class Task_4
	{
		public void FourthTask()
		{
			int[] intArray = new int[7] { 2, 3, 8 , 1 , 6 ,15 ,9 };

			Array.Sort(intArray);
			Array.Reverse(intArray);

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
