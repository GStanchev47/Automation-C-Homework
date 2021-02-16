using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2___Conditional_Statements
{
	public class Task_5
	{
		public void FifthTask()
		{
			int percentageCorrectAnswers = 52;
			int evaluation;

			if (percentageCorrectAnswers > 90)
			{
				evaluation = 6;
			}

			else if (percentageCorrectAnswers > 74)
			{
				evaluation = 5;
			}

			else if (percentageCorrectAnswers > 59)
			{
				evaluation = 4;
			}

			else if (percentageCorrectAnswers > 44)
			{
				evaluation = 3; 
			}

			else
			{
				evaluation = 2;
			}

			Console.WriteLine("The Evaluation is: " + evaluation);
		}
	}
}
