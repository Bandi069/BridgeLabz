// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LazyInitialization.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.SingletonPattern
{
    /// <summary>
    /// LazyInitialization Class of Singleton Design Pattern
    /// </summary>
    class LazyInitialization
    {
        /// <summary>
        /// Creating Object for Lazy Intialiazation
        /// </summary>
        private static readonly Lazy<LazyInitialization> SingletonObj = 
            new Lazy<LazyInitialization>(() => new LazyInitialization());
        /// <summary>
        /// Created integer Variable
        /// </summary>
        private static int Count = 0;
        /// <summary>
        /// Creating constructor for the lazyinitialization Class
        /// </summary>
        private LazyInitialization()
        {

        }
    }
}
