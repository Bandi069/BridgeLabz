using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.FactoryPattern
{
    public abstract class ComputerFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract class Computer
        {
            /// <summary>
            /// Abstract class for Computer
            /// </summary>
            /// <returns></returns>
            public abstract Computer GetComputer();
        }
    }
}
