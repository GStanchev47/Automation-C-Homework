using System;
using System.Collections.Generic;
using System.Text;
using Homework_8_Inheritance.Blocks;

namespace Homework_8_Inheritance
{
	public class Block
	{		

		private BlockType type;

		public BlockType Type { get => type; set => type = value; }

		public virtual void Break(BlockType brokenBlockType)
		{
			Console.WriteLine("Action: Player breaks " + brokenBlockType);

			Player.Inventory.Remove(brokenBlockType);

			Console.WriteLine("Result: " + brokenBlockType + " was removed from the Player's Inventory");
			Console.WriteLine("Result: Junk was dropped");

			Console.WriteLine();
			Console.WriteLine("________________________");
			Console.WriteLine();

		}

		public void Place(BlockType placedType)
		{
			Player.Inventory.Remove(placedType);

			Console.WriteLine("Action: Player places " + placedType + " on the ground" );
			Console.WriteLine("Result: " + placedType + " was removed from the Player's inventory and was placed on the ground");

			Console.WriteLine();
			Console.WriteLine("________________________");
			Console.WriteLine();
		}

		public virtual void PickUp(BlockType type)
		{

			Console.WriteLine("Action: Player picks up " + type);
			AddToInventory(type);
		}


		public void AddToInventory(BlockType type)
		{
			Player.Inventory.Add(type);

			Console.WriteLine("Result: " + type + " was added to the Player's Inventory");

			Console.WriteLine();
			Console.WriteLine("________________________");
			Console.WriteLine();

		}
	}
}
