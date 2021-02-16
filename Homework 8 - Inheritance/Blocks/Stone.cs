using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8_Inheritance.Blocks
{
	class Stone : Block
	{ 
		public override void Break(BlockType brokenBlockType)
		{
			Console.WriteLine("Action: Player breaks " + brokenBlockType);

			if (Player.Inventory.Contains(BlockType.Pickaxe))
			{
				Console.WriteLine("Result: " + BlockType.Grass + " was dropped on the ground");
			}
			else
			{
				Console.WriteLine("Result: The stone was broken without pickaxe. Nothing was dropped");
			}

			Console.WriteLine();
			Console.WriteLine("________________________");
			Console.WriteLine();
		}
	}
}
