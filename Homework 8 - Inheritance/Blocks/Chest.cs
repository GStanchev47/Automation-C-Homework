using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8_Inheritance.Blocks
{
	 class Chest : Block
	{
	       List<BlockType> chestInventory = new List<BlockType>();


		public void StoreInChest(BlockType storedType)
		{
			Console.WriteLine("Action: Player stores " + storedType + " in the Chest" );

			Player.Inventory.Remove(storedType);
			
			chestInventory.Add(storedType);
			Console.WriteLine("Result: " + storedType + " was removed from the Player's inventory and was added in the Chest");

			Console.WriteLine();
			Console.WriteLine("________________________");
			Console.WriteLine();

		}

	}
}
