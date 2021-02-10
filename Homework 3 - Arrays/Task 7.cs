using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_3___Arrays
{
	public class Task_7
	{
		public void SeventhTask()
		{
			int[,] intArray = new int[2, 3];


			intArray[0, 0] = 4;
			intArray[0, 1] = 24;
			intArray[0, 2] = 62;
			intArray[1, 0] = 42;
			intArray[1, 1] = 18;
			intArray[1, 2] = 99;

			int[,] intArray2 = new int[2, 3];


			intArray2[0, 0] = 14;
			intArray2[0, 1] = 11;
			intArray2[0, 2] = 77;
			intArray2[1, 0] = 42;
			intArray2[1, 1] = 22;
			intArray2[1, 2] = 9;

			int[,] resultArray = new int[intArray.GetLength(0), intArray.GetLength(1)];

			for (int i = 0; i < intArray.GetLength(0); i++)
			{
				for (int j = 0; j < intArray.GetLength(1); j++)
				{
					resultArray[i, j] = intArray[i, j] + intArray2[i, j];
				}
			}

			foreach (int number in resultArray)
			{
				Console.WriteLine(number);
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");
			Console.WriteLine();

		}
	}
}
