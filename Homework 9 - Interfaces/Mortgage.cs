using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_9___Interfaces
{
	

	class Mortgage : Account
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
			Console.WriteLine("Invalid Action: Withdraw cannot be made for Credit accounts");
		}

		public float CalculateInterest(int numberOfMonths, ClientType type)
		{
			float interest = 0;

			if (type == ClientType.Individual)
			{
				if (numberOfMonths > 6)
				{
					numberOfMonths -= 6;
					interest = numberOfMonths * interestRate;
				}
				else
				{
					interest = 0;
				}
			}

			else if (type == ClientType.Organization)
			{
				if (numberOfMonths <= 12)
				{
					interest = (numberOfMonths * interestRate) / 2;  
				}
				else
				{
					float firstYear;

					firstYear = (12 * interestRate) / 2;
					interest = ((numberOfMonths-12) * interestRate) + firstYear;
				}
			}
			
			return interest;
		}

		public float Balance()
		{						
			return balance;
		}
	}
}
