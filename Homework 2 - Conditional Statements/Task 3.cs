using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2___Conditional_Statements
{
	public class Task_3
	{
		public void ThirdTask()
		{
			int angle1 = 72;
			int angle2 = 15;
			int angle3 = 93;

			if (angle1 + angle2 + angle3 == 180)
			{
				Console.WriteLine("These are valid inner angles for a triangle");
			}
			else
			{
				Console.WriteLine("These are NOT valid inner angles for a triangle");
			}
		}
	}
}
