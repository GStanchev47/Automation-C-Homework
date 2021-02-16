using System;

namespace Homework_7___Methods_and_Classes
{
	class Program
	{
		static void Main(string[] args)
		{
			Student jivko = new Student("Jivko", "Minchev", 3, Student.Sex.Male, Student.Status.Inactive, new Address("Mladost", 15, 5, 24), "Gulabov");
			jivko.GenerateEmail();
			jivko.GenerateDateOfBirth();
			jivko.GenerateStudentNumber();
			jivko.PrintStudentData();

			Student galin = new Student("Galin", "Stanchev", 3);
			galin.GenerateEmail();
			galin.GenerateDateOfBirth();
			galin.GenerateStudentNumber();
			galin.PrintStudentData();

			Student maria = new Student("Maria", "Uzunova", 3, Student.Sex.Female, Student.Status.Active);
			maria.GenerateEmail();
			maria.GenerateDateOfBirth();
			maria.GenerateStudentNumber();
			maria.PrintStudentData();


		}
	}
}
