using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_9___Interfaces
{
	public class Organization : Client
	{

		Mortgage mortgage = new Mortgage();

		public ClientType Type()
		{
			return ClientType.Organization;
		}

		public void DepositingToAccount()
		{
			
			mortgage.Depositing(1000);
		}

		public float CalculateBalance()
		{
			return mortgage.Balance() + (mortgage.Balance() * mortgage.CalculateInterest(6, Type())) / 100;
		}
	}
}
