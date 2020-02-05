// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Util.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
	/// <summary>
	/// Util Class 
	/// </summary>
	class Util
	{
		/// <summary>
		/// Userinputses this instance.
		/// Method to Integer Value for user input 
		/// </summary>
		/// <returns int></returns>
		public static int userinputs()
		{
			return int.Parse(Console.ReadLine());
		}
		/// <summary>
		/// Users the input.
		/// Method to Double values for user inputs
		/// </summary>
		/// <returns double></returns>
		public static double UserInput()
		{
			return double.Parse(Console.ReadLine());
		}

		/// <summary>
		/// Couponses the specified input.
		/// </summary>
		/// <param name="input">The input.</param>
		public static void Coupons(int input)
		{
			for (int i = 1; i <= input; i++)
			{
				Random random = new Random();
				int num = random.Next(1000, 999999);
				Console.WriteLine(i + " : " + num);
			}
		}
	}
}
