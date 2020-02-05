// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TempConversion.cs" company="Bridgelabz">
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
    /// Temperature Conversion Class 
    /// From Fahrenheit to Celsius and Celsius to Fhrenheit
    /// </summary>
    class TempConversion
    {
        /// <summary>
        /// Method Temporature the conversation .
        /// </summary>
        public static void TempCon()
        {
            double Ftemp, Ctemp;
            Console.WriteLine(" Select Convesion type\n 1.Fahrenheit to celsius\n2. Celsius to  Fahrenheit");
            int Choice = Util.userinputs();
            switch(Choice) //// Switch case for Temperature Conversion type
            {
                case 1:
                    Console.WriteLine("Enter Fahrenheit Temp");
                     Ftemp = Util.userinputs();
                    Ctemp = (Ftemp - 32) * 5 / 9;
                    Console.WriteLine("Celsius TEmp" + Ctemp);
                    break;
                case 2:
                    Console.WriteLine("Enter  Celsius Temp");
                    Ctemp = Util.userinputs();
                    Ftemp = (Ctemp - 32) * 5 / 9;
                    Console.WriteLine("Fahrenheit TEmp" + Ftemp);
                    break;
                default :
                    Console.WriteLine("Invalid");
                    break;

            }
        }
    }
}
