using System;
using System.Collections.Generic;
using System.Text;


namespace Homework_3___Arrays
{
	public class Task_1
	{
		public void FirstTask()
		{
			int[,] intArray = new int[2, 2];


			intArray[0, 0] = 4;
			intArray[0, 1] = 24;
			intArray[1, 0] = 42;
			intArray[1, 1] = 18;

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
