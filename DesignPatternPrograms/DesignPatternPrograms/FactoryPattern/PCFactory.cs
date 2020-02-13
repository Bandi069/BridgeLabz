using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.FactoryPattern
{
    class PCFactory : ComputerFactory
    {
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

        public string HDD { get; private set; }
        public string CPU { get; private set; }
        public string RAM { get; private set; }

        /// <summary>
        /// Gets the computer.
        /// </summary>
        /// <returns></returns>
      /*  public override Computer GetComputer()
        {
            return PC(RAM, HDD, CPU);
        }*/
    }
}
