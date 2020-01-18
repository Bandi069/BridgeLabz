using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
	class Util
	{
		public static int userinputs()
		{
			return int.Parse(Console.ReadLine());
		}
		public static double UserInput()
		{
			return double.Parse(Console.ReadLine());
		}
		 public static void CheckGambling(int win,double trails)
		{
			Random r = new Random();
			int value = r.Next();
	
			for (int i = 0; i < trails; i++)
			{

				if (value > 0.5)
				{
					win++;
				}
			}
			

		}
		

	}
}
