using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.SingletonPattern
{
    /// <summary>
    /// 
    /// </summary>
    class EagerInitialization
    {
        private static int Count = 0;
        private static readonly EagerInitialization NewObject = new EagerInitialization();
        /// <summary>
        /// 
        /// </summary>
        private EagerInitialization()
        {
            Count++;
            Console.WriteLine("Counter Value is : " + Count);
        }
        /// <summary>
        /// 
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
