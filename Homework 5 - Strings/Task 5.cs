using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5___Strings
{
	public class Task_5
	{
		public void FifthTask()
		{
			string someString = "HelLo pRoGRAms USEr hOw ARE yoU";

			StringBuilder sb = new StringBuilder();
			

			foreach (char c in someString)
			{
				if (char.IsLower(c))
					sb.Append(char.ToUpper(c));
				else
					sb.Append(char.ToLower(c));
				
			}

			string newString = sb.ToString();

			Console.WriteLine(newString);

			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}
	}
}
