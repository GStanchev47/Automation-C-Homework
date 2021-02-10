using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4___Loops
{
	public class Task_3
	{
		public void ThirdTask()
		{
			int newLineCount = 1;


			for (int i = 1; i < 11;)
			{
				for (int j = 0; j < newLineCount; j++)
				{
					Console.Write(i);
					i++;
				}

				Console.WriteLine();
				newLineCount++;
			}

			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();

		}									
			
		
	}
}
