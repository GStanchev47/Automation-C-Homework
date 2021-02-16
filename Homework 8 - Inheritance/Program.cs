using System;
using Homework_8_Inheritance.Blocks;

namespace Homework_8_Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Player player1 = new Player();

			player1.PickUp(BlockType.Grass);
			player1.BreakItem(BlockType.Grass);

			player1.PickUp(BlockType.Charcoal);
			player1.PickUp(BlockType.Junk);
			player1.StoreInChest(BlockType.Charcoal);
			player1.StoreInChest(BlockType.Junk);

			player1.PickUp(BlockType.Wood);
			player1.Smelt(BlockType.Wood);

			player1.PickUp(BlockType.Stone);
			player1.PickUp(BlockType.Grass);
			player1.Smelt(BlockType.Stone, BlockType.Grass);

			player1.PickUp(BlockType.Charcoal);
			player1.Place(BlockType.Charcoal);

			player1.PickUp(BlockType.Stone);
			player1.BreakItem(BlockType.Stone);

			player1.PickUp(BlockType.Pickaxe);
			player1.PickUp(BlockType.Stone);
			player1.BreakItem(BlockType.Stone);

			player1.BreakItem(BlockType.Pickaxe);

			
		}
	}
}
