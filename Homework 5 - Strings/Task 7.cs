using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5___Strings
{
	public class Task_7
	{
		public void SeventhTask()
		{

			string names = "galin.stanchev";
			string domain = "@mentormate.com";

			DateTime dt = new DateTime(2021, 02, 09, 23, 20, 44);

			string year = string.Format("{0:yyyy}", dt);
			string month = string.Format("{0:MM}", dt);
			string day = string.Format("{0:dd}", dt);
			string hour = string.Format("{0:HH}", dt);
			string minute = string.Format("{0:mm}", dt);


			Console.WriteLine(names + "+" + year + month + day + hour + minute + domain);




			Console.WriteLine();
			Console.WriteLine("______________________________");
			Console.WriteLine();
		}
	}
}
