using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2___Conditional_Statements
{
	public class Task_4
	{
		public void FourthTask()
		{
			int number = 8;

			if (number < 1 || number > 9)
			{
				Console.WriteLine("Incorrect Number");
			}

			if (number < 6)
			{
				number = number * 10;
			}
			else
			{
				number = number * 100;
			}

			Console.WriteLine("The Result is: " + number);

			if (IsPrime(number))
			{
				Console.WriteLine("It is prime");
			}
			else
			{
				Console.WriteLine("It is not prime");
			}

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
