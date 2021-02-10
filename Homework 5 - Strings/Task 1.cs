using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5___Strings
{
	public class Task_1
	{
		public void FirstTask()
		{
			string word = "tenet";
			string backwards;
			char[] lettersBackwards = new char[word.Length];
			int counter = 0;

			for (int i = word.Length-1; i >= 0; i--)
			{
				lettersBackwards[counter] = word[i];
				counter++;
			}

			backwards = new string(lettersBackwards);

			if (word == backwards)
			{
				Console.WriteLine("The word \"" + word + "\" is palindrome!");
			}
			else
			{
				Console.WriteLine("The word \"" + word + "\" is not palindrome!");
			}

			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}
	}
}
