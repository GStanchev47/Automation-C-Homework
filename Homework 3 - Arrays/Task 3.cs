using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_3___Arrays
{
	public class Task_3
	{
		public void ThirdTask()
		{
			int[] intArray = new int[3] { 2, 3, 8 };
			int[] intArray2 = new int[3] { 5, 1, 4 };

			int originalLenght = intArray.Length;

			Array.Resize<int>(ref intArray, intArray.Length + intArray2.Length);
			Array.Copy(intArray2, 0, intArray, originalLenght, intArray2.Length);
			Array.Sort(intArray);


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
