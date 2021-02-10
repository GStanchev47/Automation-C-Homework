using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4___Loops
{
	public class Task_7
	{
		public void SeventhTask()
		{
			int i = 66;
			int j = 77;

			do
			{
				if (i <= 21)
				{
					Console.WriteLine("i - " + "XX");
				}

				else
				{
					Console.WriteLine("i - " + i);
					i -= 4;
				}

				if (j >= 99)
				{
					Console.WriteLine("j - " + "XX");
				}

				else
				{
					Console.WriteLine("j - " + j);
					j += 2;
				}
				
			}
			while (i >= 21 && j <= 99);

			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}

	}
}
