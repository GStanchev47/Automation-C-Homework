using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5___Strings
{
	public class Task_9
	{
		public void NinthTask()
		{
			string example = "our string % Welcome to mentorm@te1.com";

			string joinnedSentence = string.Join("", example.Split(' '));

			char[] specialChars = new char[9] { '%', '@', '.', '!', '#', '$', '^', '&', '*',};

			char[] numbers = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9'};

			int specialCharsCount = 0;

			int numbersCount = 0;

			int lettersCount = 0;

			for (int i = 0; i < joinnedSentence.Length; i++)
			{
				for (int j = 0; j < numbers.Length; j++)
				{
					if (joinnedSentence[i] == specialChars[j])
					{
						specialCharsCount++;
						break;
					}
					else if (joinnedSentence[i] == numbers[j])
					{
						numbersCount++;
						break;
					}
					else
					{						
						lettersCount++;
						break;
					}
				}
			}


			Console.WriteLine("There are: " + specialCharsCount + " special characters, " + numbersCount + " numbers and " + lettersCount + " letters in the example !");





			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}
	}
}
