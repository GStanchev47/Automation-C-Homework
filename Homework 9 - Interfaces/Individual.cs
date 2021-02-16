using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_9___Interfaces
{
	public class Individual : Client
	{
		Credit credit = new Credit();

		public ClientType Type()
		{
			return ClientType.Individual;
		}

		public void DepositingToAccount()
		{
			credit.Depositing(1000);
		}

		public float CalculateBalance()
		{
			return credit.Balance() + (credit.Balance() * credit.CalculateInterest(6, Type())) / 100;
		}

	}
}
