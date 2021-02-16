using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_9___Interfaces
{
	

	class Deposit : Account
	{
		float balance = 0;

		float interestRate = 5;

		public void Depositing(float value)
		{
			balance += value;
			Console.WriteLine("Deposit of " + value + " has been made !");
		}

		public void Withdrawing(float value)
		{
			if (value <= balance)
			{
				balance -= value;
				Console.WriteLine("Withdraw of " + value + " has been made !");
			}
			else
			{
				Console.WriteLine("Not enough money in the account");
			}
			
		}

		public float CalculateInterest(int numberOfMonths, ClientType type)
		{
			if (Balance() < 1000)
			{
				return 0;
			}

			else
			{
				float interest;
				interest = numberOfMonths * interestRate;
				return interest;
			}
		}

		public float Balance()
		{						
			return balance;
		}
	}
}
