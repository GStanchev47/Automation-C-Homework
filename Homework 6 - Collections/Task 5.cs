using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6___Collections
{
	public class Task_5
	{
		public void FifthTask()
		{

			List<string> firstString = new List<string>();

			firstString.Add("Black");
			firstString.Add("Red");
			firstString.Add("Maroon");
			firstString.Add("Yellow");

			List<string> secondString = new List<string>();

			secondString.Add("#000000");
			secondString.Add("#FF0000");
			secondString.Add("#800000");
			secondString.Add("#FFFF00");

			Dictionary<string, string> resultConverter = new Dictionary<string, string>();

			for (int i = 0; i < firstString.Count; i++)
			{
				resultConverter.Add(firstString[i], secondString[i]);
			}

			foreach (KeyValuePair<string, string> keys in resultConverter)
			{
				Console.WriteLine(keys.Key + " " + keys.Value);				
			}



			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}
	}
}
