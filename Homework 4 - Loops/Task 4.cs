using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4___Loops
{
	public class Task_4
	{
		public void FourthTask()
		{
			int number = 5;
			int result = 1;

			for (int i = number; i > 0; i--)
			{
				result = result * i;
			}

			Console.WriteLine(result);
			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}
	}
}
