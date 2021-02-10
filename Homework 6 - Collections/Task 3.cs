using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6___Collections
{
	public class Task_3
	{
		public void ThirdTask()
		{
			List<string> example = new List<string>();

			int count = 0;

			example.Add("apple");
			example.Add("banana");
			example.Add("orange");
			example.Add("tomato");
			example.Add("carrot");
			example.Add("papaya");
			example.Add("pitanga");

			string compareString = "pa";

			for (int i = 0; i < example.Count; i++)
			{
				if (example[i].Length > 2 && compareString[0] == example[i][0] && compareString[1] == example[i][example[i].Length -1])
				{
					count++;
				}
			}

			Console.WriteLine(count);


			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();

		}
	}
}
