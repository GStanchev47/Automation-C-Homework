using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6___Collections
{
	public class Task_2
	{
		public void SecondTask()
		{

			bool contains = false;

			List<char> collection = new List<char>();

			collection.Add('a');
			collection.Add('b');
			collection.Add('g');
			collection.Add('k');
			collection.Add('y');
			collection.Add('r');
			collection.Add('v');
			collection.Add('f');
			collection.Add('s');
			collection.Add('v');
			collection.Add('w');


			List<char> collection2 = new List<char>();
			collection2.Add('g');
			collection2.Add('v');
			collection2.Add('f');
			collection2.Add('s');


			for (int i = 0; i < collection2.Count; i++)
			{
				if (collection.Contains(collection2[i]))
				{
					contains = true;
				}
			}

			Console.WriteLine(contains);

			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();


		}
	}
}
