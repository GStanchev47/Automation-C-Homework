using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5___Strings
{
	public class Task_3
	{
		public void ThirdTask()
		{
			string sentence = "The two walked down the slot canyon oblivious to the sound of thunder in the distance.";
			string[] words = sentence.Split(' ');
			string collectedWords = "";
			int aCounter = 0;
			int sCounter = 0;
			int eCounter = 0;

			for (int i = 0; i < words.Length; i++)
			{
				collectedWords += words[i];
			}

			for (int i = 0; i < collectedWords.Length - 1; i++)
			{
				if (collectedWords[i] == 'a')
				{
					aCounter++;
				}

				else if(collectedWords[i] == 's')
			    {
					sCounter++;
				}

				else if(collectedWords[i] == 'e')
				{
					eCounter++;
				}
			}

			Console.WriteLine("The letter \"a\" is met: " + aCounter + " times");
			Console.WriteLine("The letter \"s\" is met: " + sCounter + " times");
			Console.WriteLine("The letter \"e\" is met: " + eCounter + " times");

			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();

		}
	}
}
