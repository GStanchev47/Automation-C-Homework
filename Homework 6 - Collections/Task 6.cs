using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6___Collections
{
	public class Task_6
	{
		public void SixthTask()
		{
			List<int> firstList = new List<int>();

			firstList.Add(1);
			firstList.Add(3);
			firstList.Add(5);
			firstList.Add(7);
			firstList.Add(9);
			firstList.Add(10);

			List<int> secondList = new List<int>();

			secondList.Add(2);
			secondList.Add(4);
			secondList.Add(6);
			secondList.Add(8);

			firstList.RemoveAt(firstList.Count - 1);

			foreach (int number in secondList)
			{
				firstList.Add(number);
			}

			for (int i = 0; i < firstList.Count; i++)
			{
				Console.WriteLine(firstList[i]);
			}


			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}
	}
}
