// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Quadratic.cs" company="Bridgelabz">
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
    /// Class for Quadratic Equations Roots Finding
    /// </summary>
    class Quadratic
    {
        /// <summary>
        /// Finds the roots of Quadratic Equation.
        /// </summary>
        public static void FindRoots()
        {
            Console.WriteLine("Enter Quotiesnts of quadratic equation");
            double a = Util.UserInput();
            double b = Util.UserInput();
            double c = Util.UserInput();
            double Determinant = (b*b - 4 * a * c);
            if (Determinant == 0)
            {
                double root = (-b / 2 * a);
                Console.WriteLine("Root with Det 0 is with same roots Given as " + root );
            }
            if(Determinant >0 || Determinant < 0)
            {
                double root1 = (-b + Math.Sqrt(Determinant))/2*a;
                Console.WriteLine("root 1 is" + root1);
                double root2 = (-b - Math.Sqrt(Determinant)) / 2 * a;
                Console.WriteLine("root 2 is" + root2);
            }
          
        }

    }
}
