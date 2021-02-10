using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6___Collections
{
	public class Task_4
	{
		public void FourthTask()
		{
			bool containsInFirst = false;
			bool containsInSecond = false;


			List<char> collection = new List<char>();

			collection.Add('a');
			collection.Add('b');
			collection.Add('g');
			collection.Add('k');
			collection.Add('y');
			collection.Add('r');


			List<char> collection2 = new List<char>();
			collection2.Add('g');
			collection2.Add('v');
			collection2.Add('f');
			collection2.Add('s');
			collection2.Add('l');


			for (int i = 0; i < collection.Count; i++)
			{
				if (collection.Contains(collection[i]))
				{
					containsInFirst = true;
				}
			}

			for (int i = 0; i < collection2.Count; i++)
			{
				if (collection.Contains(collection2[i]))
				{
					containsInSecond = true;
				}
			}

			if (containsInFirst && containsInSecond)
			{
				Console.WriteLine(containsInFirst);
			}


			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();

		}
	}
}
