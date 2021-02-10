using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4___Loops
{
	public class Task_8
	{
		public void EightTask()
		{
			int i = 97;
			int counter = 1;

			while (i >= 54)
			{
				if (counter == 4 || counter == 7)
				{
					counter++;
					i -= 3;
					continue;
				}
				else
				{
					Console.WriteLine(i);
					counter++;
					i -= 3;
				}
			}
		}
	}
}
