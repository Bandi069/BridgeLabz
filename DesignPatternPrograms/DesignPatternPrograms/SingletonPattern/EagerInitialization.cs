using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.SingletonPattern
{
    /// <summary>
    /// Class for the Eager Initialization of Design Pattern of Singleton
    /// </summary>
    class EagerInitialization
    {
        /// <summary>
        /// Initializing Count value as Private static integer  
        /// </summary>
        private static int Count = 0;
        /// <summary>
        /// Instance (NewObject) is created for EagerInitialization
        /// </summary>
        private static readonly EagerInitialization NewObject = new EagerInitialization();
        /// <summary>
        /// Constructor for for EagerInitialization class
        /// </summary>
        public EagerInitialization()
        {
            Count++;
            Console.WriteLine("Counter Value is : " + Count);
        }
        /// <summary>
        ///  Static get method 
        /// </summary>
        public static EagerInitialization GetSingleton
        {
            get
            {
                return NewObject;
            }
        }

        /// <summary>
        /// Method to specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Message(string message)
        {
            Console.WriteLine(message);
        }

    }
}
