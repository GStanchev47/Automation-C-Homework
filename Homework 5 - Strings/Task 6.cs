using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5___Strings
{
	public class Task_6
	{
		public void SixthTask()
		{
			string names = "galin.stanchev";
			string domain = "@mentormate.com";

			for (int i = 0; i <= 1; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					for (int k = 0; k < 10; k++)
					{
						Console.WriteLine(names + "+" + i + j + k + domain);
						if (i == 1)
						{
							return;		
						}
						
					}
					
				}
				

			}

			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}

	}
}
