using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_9___Interfaces
{
	interface Account
	{
		public void Withdrawing(float value);

		public void Depositing(float value);

		public float CalculateInterest(int numberOfMonths, ClientType type);

		public float Balance();

	}
}
