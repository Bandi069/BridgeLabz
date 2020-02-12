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
        private static readonly Lazy<LazyInitialization> LazySingletonObj =
            new Lazy<LazyInitialization>(() => new LazyInitialization());
        /// <summary>
        /// Created integer Variable
        /// </summary>
        private static int Count = 0;
        /// <summary>
        /// returning the singleton value
        /// </summary>
        public static LazyInitialization GetSingletonLazy
        {
            //// returing the value 
            get
            {
                return LazySingletonObj.Value;
            }
        }
        /// <summary>
        /// Creating constructor for the lazy initialization Class
        /// </summary>
        private LazyInitialization()
        {
            Count++;
            Console.WriteLine("Counter Value : "+Count);
        }
        /// <summary>
        /// Method for Displaying the message 
        /// </summary>
        /// <param name="message"></param>
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
