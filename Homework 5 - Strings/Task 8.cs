using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5___Strings
{
	public class Task_8
	{
		public void EightTask()
		{

			string sentence = "The two walked down.";
			string[] words = sentence.Split(' ');

			bool recorded = false;

			string joinnedSentence = string.Join("", words);
			joinnedSentence = joinnedSentence.ToLower();
			

			Console.WriteLine(joinnedSentence);

			char[] dublicatedChars = new char[joinnedSentence.Length];

			for (int i = 0; i < joinnedSentence.Length; i++)
			{
				for (int j = 0; j < joinnedSentence.Length; j++)
				{
					if (i == j)
					{
						continue;
					}
					

					if (joinnedSentence[i] == joinnedSentence[j])
					{
						recorded = false;
						for (int k = 0; k < dublicatedChars.Length; k++)
						{
							if (joinnedSentence[i] == dublicatedChars[k])
							{
								recorded = true;								
							}

						}

						if (!recorded)
						{
							for (int k = 0; k < dublicatedChars.Length; k++)
							{
								if (dublicatedChars[k] == '\0')
								{
									dublicatedChars[k] = joinnedSentence[i];
									break;
								}
								
							}
						}
						
						break;
					}
					
				}
			}

			Console.WriteLine();

			for (int i = 0; i < dublicatedChars.Length; i++)
			{
				Console.WriteLine(dublicatedChars[i]);
			}





			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}
	}
}
