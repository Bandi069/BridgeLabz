﻿/*// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainFactory.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.FactoryPattern
{
    /// <summary>
    /// This is Main FactoryClass 
    /// </summary>
    class MainFactory
    {
        /// <summary>
        /// This is Method for Factory Production
        /// </summary>
        public void FactoryProduction()
        {
            ComputerFactory Factory = null;
            Console.WriteLine("Enter a Choice to get the Details of computer");
            Console.WriteLine("1. PC\n2. Laptop\n3. Server");
            int Choice = int.Parse(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("PC Type Computer ");
                    PC factory = new PC("4 GB", "3 GB", "2GB");
                    break;
                default:
                    Console.WriteLine("Entered Invalid Choice...Enter a Valid Choice");
                    break;
            }
            Computer comp = Factory.GetComputer();
            Console.WriteLine("RAM :" + comp.RAM + "HDD :" + comp.HDD + "CPU :" + comp.CPU);
        }
    }
}
*/