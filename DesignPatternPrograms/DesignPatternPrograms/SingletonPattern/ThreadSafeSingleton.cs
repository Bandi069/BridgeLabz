﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Threadsafe.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.SingletonPattern
{
    class ThreadSafeSingleton
    {
        private static int Counter = 0;
        /// <summary>
        /// Instance is created for Threadsafe Singleton
        /// </summary>
        private static ThreadSafeSingleton SingletonObj = null;
        /// <summary>
        /// create single object with read only keyword
        /// </summary>
        private static readonly object ObjectLock = new object();
        /// <summary>
        /// Constructor is Created for Threadsafe Singleton
        /// </summary>
        private ThreadSafeSingleton()
        {
            Counter++;
            Console.WriteLine("Counter Value is : " + Counter);
        }
        /// <summary>
        /// 
        /// </summary>
        public static ThreadSafeSingleton GetThreadSingleton
        {
            get
            {
                /*if (SingletonObj == null)
                {
                    lock (ObjectLock)
                    {

                    }
                }*/
                return SingletonObj;
            }
            
        }
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
