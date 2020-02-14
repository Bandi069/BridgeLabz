// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Target.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.AdapterDesignPattern
{
    /// <summary>
    /// Target InterFace to get the string List
    /// </summary>
    public interface Target
    {
        /// <summary>
        /// Get method
        /// </summary>
        /// <returns></returns>
        public List<string> GetProducts();
    }
}
