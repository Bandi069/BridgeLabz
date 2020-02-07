// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Oops.InventaoryManagement
{
    /// <summary>
    /// Utility class
    /// </summary>
    class Utility
    {
        /// <summary>
        /// Getter setter for Name in String Type
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Getter setter for Weight Object
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// Getter setter for Price Object
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// To read User Input value of Integer 
        /// </summary>
        /// <returns Int></returns>
        public int IntUser()
        {
            return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// To read User string input value
        /// </summary>
        /// <returns String></returns>
        public string StringUserInput()
        {
            return Console.ReadLine();
        }
    }
}
