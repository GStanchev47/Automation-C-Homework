using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_7___Methods_and_Classes
{
	public class Address
	{
		string street;

		int buildingNumber;

		int floor;

		int roomNumber;

		public Address(string _street, int _buildingNumber, int _floor, int _roomNumber)
		{
			street = _street;
			buildingNumber = _buildingNumber;
			floor = _floor;
			roomNumber = _roomNumber;		
			
		}
	}
}
