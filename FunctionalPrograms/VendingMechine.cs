// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="Bridgelabz">
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
	/// Veninding Machine Class
	/// </summary>
	class VendingMechine
    {
		/// <summary>
		/// Countings the machine.
		/// </summary>
		public static void CountingMachine()
        {	
			Console.WriteLine("Enter No of Notes");
			int n = Util.userinputs();
			Console.WriteLine("Enter Amounts");
			int[] notes = new int[n];// {2000,1000,,500,100,50,1,2,}
			
			for(int i=0;i<notes.Length;i++)
			{
				notes[i] = (Util.userinputs()); //// Notes array
			}
			Console.WriteLine("Enter Amount");
			int amount = Util.userinputs();
				int[] noteCounter = new int[n]; //// Note Counter array
				for (int i = 0; i < notes.Length; i++)
				{
					if (amount >= notes[i])
					{
						noteCounter[i] = amount / notes[i];
						amount = amount - noteCounter[i] * notes[i];
					}
				}

				// Printing number of notes
				Console.WriteLine("Notes Demonistation Count ");
				for (int i = 0; i < n ; i++)
				{
					if (noteCounter[i] != 0)
					{
						Console.WriteLine(notes[i] + " -> "	+ noteCounter[i]);
					}
				}
			}


	}
}

