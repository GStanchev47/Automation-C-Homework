using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8_Inheritance.Blocks
{
	class Pickaxe : Block
	{
		public override void Break(BlockType brokenBlockType)
		{
			Console.WriteLine("Action: Player breaks " + brokenBlockType);

			Random random = new Random();

			Player.Inventory.Remove(brokenBlockType);

			Console.WriteLine("Result: " + brokenBlockType + " was removed from the Player's inventory");

			Console.WriteLine("Result: " + (BlockType)random.Next(Enum.GetNames(typeof(BlockType)).Length - 1) + " was dropped on the ground");

			Console.WriteLine();
			Console.WriteLine("________________________");
			Console.WriteLine();
		}
	}
}
