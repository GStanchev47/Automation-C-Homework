using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_7___Methods_and_Classes
{
	public class Student
	{
		private string name;

		private string lastName;

		private string studentNumber;

		private int specialty;

		private string email;

		private string dateOfBirth;

		private int admissionYear;

		public enum Sex {Null, Male, Female };

		private Sex sex;

		private string birthTown;

		public enum Status {Null, Active, Inactive };

		private Status status;


		private Address address;


		private int dayOfBirth;
		private int monthOfBirth;
		private int yearOfBirth;

		public Student(string _name, string _lastName, int _specialty)
		{
			name = _name;
			lastName = _lastName;
			specialty = _specialty;			
		}

		public Student(string _name, string _lastName, int _specialty, Sex _sex, Status _status)
		{
			name = _name;
			lastName = _lastName;
			specialty = _specialty;
			sex = _sex;
			status = _status;
		}

		public Student(string _name, string _lastName, int _specialty, Sex _sex, Status _status, Address _address, string _birthTown)
		{
			name = _name;
			lastName = _lastName;
			specialty = _specialty;
			birthTown = _birthTown;
			sex = _sex;
			status = _status;
			address = _address;
		}

		public void GenerateEmail()
		{
			email = name + lastName + "@mentormate.com";
		}

		public void GenerateDateOfBirth()
		{
			Random random = new Random();
			dayOfBirth = random.Next(1, 30);
			monthOfBirth = random.Next(1, 12);
			yearOfBirth = random.Next(1918, 2000);
			dateOfBirth = "" + dayOfBirth +  monthOfBirth + yearOfBirth;
		}
		
		public void PrintStudentData()
		{
			Console.WriteLine("The Name of the Student: " + name);
			Console.WriteLine("The Last Name of the Student: " + lastName);
			Console.WriteLine("The Specialty code of the Student: " + specialty);
			Console.WriteLine("The Specialty code of the Student: " + email);			
			Console.WriteLine("The Student's number: " + studentNumber);								
			Console.WriteLine("The Date of birth of the Student: " + "" + dayOfBirth + "." + monthOfBirth + "." + yearOfBirth);			
			Console.WriteLine("The Admission Year of the Student: " + admissionYear);
			if (sex != Sex.Null)
			{
				Console.WriteLine("The Gender of the Student: " + sex);
			}

			if (birthTown != null)
			{
				Console.WriteLine("The Birth Town of the Student: " + birthTown);
			}

			if (status != Status.Null)
			{
				Console.WriteLine("The Status of the Student's rights: " + status);
			}

			if (address != null)
			{
				Console.WriteLine("The Address of the Student: " + address);
			}
			


			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}

		public void GenerateStudentNumber()
		{
			Random random = new Random();

			admissionYear = random.Next(yearOfBirth + 19, 2021);			

			studentNumber = "" + admissionYear + specialty + dateOfBirth + random.Next(9) + random.Next(9);
		}
	}

}
