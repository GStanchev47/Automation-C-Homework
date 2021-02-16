using System;

namespace Homework_9___Interfaces
{
	class Program
	{
		static void Main(string[] args)
		{
			Individual individual = new Individual();
			individual.DepositingToAccount();
			Console.WriteLine("The balance of the account after 6 months with initial balance of 1000 will be: " + individual.CalculateBalance());

			Organization organization = new Organization();
			organization.DepositingToAccount();
			Console.WriteLine("The balance of the account after 6 months with initial balance of 1000 will be: " + organization.CalculateBalance());
		}
	}
}
