using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
	class UserStringName
	{
		public static void StringReplace()
		{
			string question = "Hello <<username>> ,How are you?";
			Console.WriteLine("enter name to replace");
			string str = Console.ReadLine();
			int l = str.Length;
			if(l>=3)
			{
				Console.WriteLine(question.Replace("<<username>>",str));
			}
		}
	}
	
}
