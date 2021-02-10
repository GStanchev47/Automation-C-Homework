using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6___Collections
{
	public class Task_1
	{
		public void FirstTask()
		{
			List<int> collection = new List<int>();
			List<int> collectionAddResult = new List<int>();
			List<int> collectionMultiplyResult = new List<int>();
			List<int> collectionSquareResult = new List<int>();



			collection.Add(1);
			collection.Add(42);
			collection.Add(22);
			collection.Add(12);
			collection.Add(51);
			collection.Add(2);


			foreach (int number in collection)
			{
				collectionAddResult.Add(number + 10);
				collectionMultiplyResult.Add(number * 2);
				collectionSquareResult.Add(number * number);
			}

			Console.WriteLine();
			Console.WriteLine("Adding Result:");
			for (int i = 0; i < collectionAddResult.Count; i++)
			{
				Console.WriteLine(collectionAddResult[i]);
			}

			Console.WriteLine();
			Console.WriteLine("Multiplying Result:");
			for (int i = 0; i < collectionMultiplyResult.Count; i++)
			{
				Console.WriteLine(collectionMultiplyResult[i]);
			}

			Console.WriteLine();
			Console.WriteLine("Square Result:");
			for (int i = 0; i < collectionSquareResult.Count; i++)
			{
				Console.WriteLine(collectionSquareResult[i]);
			}



			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();

		}
	}
}
