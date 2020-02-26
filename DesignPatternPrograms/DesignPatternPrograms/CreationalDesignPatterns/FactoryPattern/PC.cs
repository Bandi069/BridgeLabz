// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PC.cs" company="Bridgelabz">
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
    /// This is PC Class 
    /// </summary>
    public class PC : Computer
    {
        private string RAM;
        private string HDD;
        private string CPU;
        /// <summary>
        /// This is instance of PC
        /// </summary>
        /// <param name="ram"></param>
        /// <param name="hdd"></param>
        /// <param name="cpu"></param>
        public PC(string ram, string hdd, string cpu)
        {
            Ram = ram;
            Hdd = hdd;
            Cpu = cpu;
        }
        /// <summary>
        /// This is property instnace of Ram
        /// </summary>
        public string Ram { get; set; }
        /// <summary>
        /// This is Property instance of Hdd
        /// </summary>
        public string Hdd { get; set; }
        /// <summary>
        /// This is Property instance of Cpu
        /// </summary>
        public string Cpu { get; set; }

    }
    /// <summary>
    /// This is get method for Computer
    /// </summary>
    /// <returns></returns>
    public override Computer GetComputer()
    {
        return new PC(RAM, HDD, CPU);
    }
}
