using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8_Inheritance.Blocks
{
	class Furnace : Block
	{
		public void Smelt(BlockType blockToSmelt1, BlockType blockToSmelt2)
		{
			

			if (blockToSmelt2 != BlockType.Null)
			{
				Console.WriteLine("Action: Player smelts " + blockToSmelt1 + " and " + blockToSmelt2);
			}

			else
			{
				Console.WriteLine("Action: Player smelts " + blockToSmelt1);
			}

			Random random = new Random();

			Player.Inventory.Remove(blockToSmelt1);

			Console.WriteLine("Result: " + blockToSmelt1 + " was removed from the Player's inventory");

			if (blockToSmelt2 != BlockType.Null)
			{
				Player.Inventory.Remove(blockToSmelt2);
				Console.WriteLine("Result: " + blockToSmelt2 + " was removed from the Player's inventory");

				BlockType addedItem = (BlockType)random.Next(Enum.GetNames(typeof(BlockType)).Length - 1);

				Player.Inventory.Add(addedItem);

				Console.WriteLine("Result: " + addedItem + " was added to the Player's inventory");

				
				Console.WriteLine();
			}

			else if (blockToSmelt1 == BlockType.Wood && blockToSmelt2 == BlockType.Null)
			{
				Player.Inventory.Add(BlockType.Charcoal);

				

				Console.WriteLine("Result: " +  BlockType.Charcoal + " was added to the Player's inventory");
			}

			else if (blockToSmelt1 == BlockType.Charcoal && blockToSmelt2 == BlockType.Null)
			{
				Player.Inventory.Add(BlockType.Stone);

				

				Console.WriteLine("Result: " + BlockType.Stone + " was added to the Player's inventory");
			}

			Console.WriteLine();
			Console.WriteLine("________________________");
			Console.WriteLine();

		}

	}
}
