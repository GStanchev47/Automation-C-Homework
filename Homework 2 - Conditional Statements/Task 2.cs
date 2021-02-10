using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2___Conditional_Statements
{
	public class Task_2
	{
		public void SecondTask()
		{
			int a = 3;
			int b = 14;
			int c = 7;


			if (a > b && a > c)
			{
				Console.WriteLine("The biggest number is a: " + a);
			}

			else if (b > a && b > c)
			{
				Console.WriteLine("The biggest number is b: " + b);
			}

			else if (c > a && c > b)
			{
				Console.WriteLine("The buggest nubmer is c: " + c);
			}

		}
	}
}
