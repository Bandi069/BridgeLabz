// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PCFactory.cs" company="Bridgelabz">
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
    /// This is PC Factory class interface by Computer Factory
    /// </summary>
    class PCFactory : ComputerFactory
    {
        /// <summary>
        ///  Private String declaration of Ram,Hdd,Cpu
        /// </summary>
        private string Ram, Hdd, Cpu;
                
        /// <summary>
        /// Initializes a new instance
        /// </summary>
        /// <param name="Ram"></param>
        /// <param name="Hdd"></param>
        /// <param name="Cpu"></param>
        public PCFactory(string Ram, string Hdd, string Cpu)
        {
            RAM = Ram;
            HDD = Hdd;
            CPU = Cpu;
        }
        /// <summary>
        /// Property instnace of HDD
        /// </summary>
        public string HDD { get; private set; }
        /// <summary>
        /// This is Property Instance of CPU
        /// </summary>
        public string CPU { get; private set; }
        /// <summary>
        /// This is Property instnace of RAM
        /// </summary>
        public string RAM { get; private set; }

        /// <summary>
        /// Gets the computer.
        /// </summary>
        /// <returns></returns>
        public override Computer GetComputer()
        {
            return PC(RAM, HDD, CPU);
        }
    }
}
