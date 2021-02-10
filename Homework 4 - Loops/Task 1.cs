using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4___Loops
{
	public class Task_1
	{
		public void FirstTask()
		{
			int firstNumber = 62;
			int SecondNumber = 11;

			if (SecondNumber < firstNumber)
			{
				for (int i = SecondNumber; i <= firstNumber; i++)
				{
					if (IsPrime(i))
					{
						Console.WriteLine(i + "");
					}
				}
			}
			else
			{
				for (int i = firstNumber; i <= SecondNumber; i++)
				{
					if (IsPrime(i))
					{
						Console.WriteLine(i + "");
					}
				}
			}

			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
			
		}
		public static bool IsPrime(int number)
		{
			if (number <= 1) return false;
			if (number == 2) return true;
			if (number % 2 == 0) return false;

			var boundary = (int)Math.Floor(Math.Sqrt(number));

			for (int i = 3; i <= boundary; i += 2)
				if (number % i == 0)
					return false;

			return true;
		}
	}

}
