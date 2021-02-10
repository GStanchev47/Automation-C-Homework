using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_5___Strings
{
	public class Task_4
	{
		public void FourthTask()
		{
			string sentence = "The two walked down the slot canyon oblivious to the sound of thunder in the distance.";

			string[] words = sentence.Split(' ');

			string reversed = "";

			Array.Reverse(words);

			reversed = string.Join(" ", words);		

			reversed = string.Join(" ", reversed.Split(' ').Select(x => new String(x.Reverse().ToArray())));

			Console.WriteLine(reversed);

			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}
	}
}
