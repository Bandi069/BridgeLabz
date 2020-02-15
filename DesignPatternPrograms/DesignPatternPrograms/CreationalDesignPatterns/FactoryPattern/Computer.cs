// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Computer.cs" company="Bridgelabz">
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
    /// This is abstract class of computer 
    /// Giving all the properties of computer.cd
    /// </summary>
    public abstract class Computer
    {
        /// <summary>
        /// this is instance of RAM
        /// </summary>
        public string RAM { get; set; }
        /// <summary>
        /// This is Property of HDD
        /// </summary>
        public string HDD { get; set; }
        /// <summary>
        /// This is Property of CPU
        /// </summary>
        public string CPU { get; set; }
    }
}
