 //--------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySearchTree.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
	/// <summary>
	/// Binary Search Tree Class
	/// </summary>
    class BinarySearchTree
    {
		/// <summary>
		/// Factorial of the nodes.
		/// </summary>
		public void Tree()
		{
			Console.WriteLine("Enter number  to get Possible number of Binary Trees ");
			int Nodes = Utility.UserIntInput();

			int numberOfBST = Utility.Factorial(2 * Nodes) / (Utility.Factorial(Nodes + 1) * Utility.Factorial(Nodes));
			Console.WriteLine(numberOfBST + " Binary Search Trees are possible for " + Nodes + " nodes");

		}
	}
}
