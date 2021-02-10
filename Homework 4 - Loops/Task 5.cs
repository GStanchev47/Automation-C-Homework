using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4___Loops
{
	public class Task_5
	{
		public void FifthTask()
		{
			int number = 5;
			int count = number;

			for (int i = 0; i < number; i++)
			{
				for (int j = number - 1; j >= 0; j--)
				{
					Console.Write(count - j);
				}
				count++;
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}
	}
}
