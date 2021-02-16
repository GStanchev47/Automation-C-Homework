using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6___Collections
{
	public class Task_7
	{
		public void SeventhTask()
		{
			int number = 5;

			Dictionary<int, int> result = new Dictionary<int, int>();

			for (int i = 1; i <= number; i++)
			{
				result.Add(i, i * i);
			}

			foreach (KeyValuePair<int, int> keys in result)
			{
				Console.WriteLine(keys.Key + " " + keys.Value);
			}


			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}
	}
}
