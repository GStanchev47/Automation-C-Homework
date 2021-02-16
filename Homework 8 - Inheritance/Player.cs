using System;
using System.Collections.Generic;
using System.Text;
using Homework_8_Inheritance.Blocks;

namespace Homework_8_Inheritance
{
	public class Player
	{
		 Block block = new Block();
		 Furnace furnace = new Furnace();
		 Grass grass = new Grass();
		 Pickaxe pickaxe = new Pickaxe();
		 Stone stone = new Stone();
		 Chest chest = new Chest();
		 
		 
	     static List<BlockType> inventory = new List<BlockType>();

	     public static List<BlockType> Inventory { get => inventory; set => inventory = value; }

		public void PickUp(BlockType type)
		{
			block.PickUp(type);
		}

		public void BreakItem(BlockType type)
		{
			if (type == BlockType.Grass)
			{
				grass.Break(type);
			}

			else if (type == BlockType.Pickaxe)
			{
				pickaxe.Break(type);
			}

			else if (type == BlockType.Stone)
			{
				stone.Break(type);
			}

			else
			{
				block.Break(type);
			}

		}
	
		public void Smelt(BlockType type1, BlockType type2 = BlockType.Null)
		{
			furnace.Smelt(type1, type2);
		}

		public void StoreInChest(BlockType type)
		{
			chest.StoreInChest(type);
		}

		public void Place (BlockType type)
		{
			block.Place(type);
		}
	}
}
