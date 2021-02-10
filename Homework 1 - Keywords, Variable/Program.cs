using System;

namespace Homework_1___Keywords__Variable
{
	class Program
	{
		public void EmployeeInit()
		{
			Task8 task8 = new Task8();

			task8.fName = "Mariq";
			task8.lastName = "Uzunova";
			task8.age = 21;
			task8.egn = "9708256589";
			task8.employeeNum = "16302600";

			Console.WriteLine("First Name of the Employee - " + task8.fName);
			Console.WriteLine();
			Console.WriteLine("Last Name of the Employee - " + task8.lastName);
			Console.WriteLine();
			Console.WriteLine("Age of the Employee: " + task8.age);
			Console.WriteLine();
			Console.WriteLine("Employee Number: " + task8.employeeNum);

		}
		

		static void Main(string[] args)
		{
			char capG;
			char a;
			char l;
			char i;
			char n;

			capG = '\x0047';
			a = '\x0061';
			l = '\x006C';
			i = '\x0069';
			n = '\x006E';

			Console.Write(capG + "" + a + "" + l + "" + "" + i + "" + n);
			Console.WriteLine();
			Console.WriteLine("________________________________________");
			Console.WriteLine();

			char aCapG;
			char aA;
			char aL;
			char aI;
			char aN;

			aCapG = '\x47';
			aA = '\x61';
			aL = '\x6C';
			aI = '\x69';
			aN = '\x6E';


			Console.WriteLine(aCapG + "" + aA + "" + aL + "" + aI + "" + aN);
			Console.WriteLine();

			Console.WriteLine("\\\'Hello\'" + " " + "to\\\\\\" + " " + "\"World\"" + " \\\'");
			Console.WriteLine();

			int smallestPossibleNumeric = -32768;

			Console.WriteLine(smallestPossibleNumeric);
			Console.WriteLine();

			smallestPossibleNumeric = 32768;

			Console.WriteLine(smallestPossibleNumeric);
			Console.WriteLine();

			float num1 = 20;
			float num2 = 30;
			float devideResult = num1 / num2;

			Console.WriteLine(num1 + num2); // 20 + 30 = 50
			Console.WriteLine();
			Console.WriteLine(num1 - num2); // 20 - 30 = -50
			Console.WriteLine();
			Console.WriteLine(num1 * num2); // 20 * 30 = 600
			Console.WriteLine();
			Console.WriteLine(devideResult); // 20 / 30 = 0.66 - our numeric type for num1 and num2 is float only because this case. If there were integer, we would print out only the whole number - 0;
			Console.WriteLine();
			Console.WriteLine(num1 % num2); // 20 % 30 = 20
			Console.WriteLine();
			Console.WriteLine("________________________________________________");
			Console.WriteLine();



			Program program = new Program();
			program.EmployeeInit();


		}
		
	}
}
	
