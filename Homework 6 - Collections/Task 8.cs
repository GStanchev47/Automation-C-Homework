using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6___Collections
{
	public class Task_8
	{
		public void EightTask()
		{
			string inputString = "randomstring";			
			Dictionary<char, int> result = new Dictionary<char, int>();

			for (int i = 0; i < inputString.Length / 2 ; i++)
			{
				int count = 1;

				for (int j = 0; j < inputString.Length; j++)
				{				
					if (i == j)
					{
						continue;
					}

					if (inputString[i] == inputString[j])
					{
						count++;
					}						
				}

				if (!result.ContainsKey(inputString[i]))
				{					
					result.Add(inputString[i], count);
				}
			}

			foreach (KeyValuePair<char, int> keys in result)
			{
				Console.WriteLine(keys.Key + " " + keys.Value);
			}

			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}
	}
}
