using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5___Strings
{
	public class Task_2
	{
		public void SecondTask()
		{
			string sentence = "He kept telling himself that one day it would all somehow make sense.";

			string[] words = sentence.Split(' ');

			Console.WriteLine("The Sentence has: " + words.Length + " words");

			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}
	}
}
