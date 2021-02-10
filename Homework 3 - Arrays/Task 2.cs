using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_3___Arrays
{
	public class Task_2
	{
		public void SecondTask()
		{
			int[,] intArray = new int[2, 3];


			intArray[0, 0] = 4;
			intArray[0, 1] = 24;
			intArray[0, 2] = 62;
			intArray[1, 0] = 42;
			intArray[1, 1] = 18;
			intArray[1, 2] = 99;



			for (int i = intArray.GetLength(0) - 1; i >= 0 ; i--)
			{
				for (int j = intArray.GetLength(1) - 1; j >= 0; j--)
				{
					Console.WriteLine(intArray[i,j]);
				}
			}

			Console.WriteLine();
			Console.WriteLine("---------------------------------------");
			Console.WriteLine();

		}
	}
}
