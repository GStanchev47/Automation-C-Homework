using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2___Conditional_Statements
{
	public class Task_1
	{
		public void FirstTask()
		{
			int a = 4;
			int b = 5;

			if (a%2 == 0)
			{
				Console.WriteLine("Number is even");
			}
			else
			{
				Console.WriteLine("Number is odd");
			}

			if (b%2 == 0)
			{
				Console.WriteLine("Number is even");
			}
			else
			{
				Console.WriteLine("Number is odd");
			}

			if (a%2 == 0 && b%2 == 0)
			{
				Console.WriteLine("Both numbers are even");
			}
			else if (a%2 != 0 && b!= 0)
			{
				Console.WriteLine("Both numbers are odd");
			}
			else
			{
				Console.WriteLine("One of the number is even and the other is odd");
			}

			
		}
	}
}
