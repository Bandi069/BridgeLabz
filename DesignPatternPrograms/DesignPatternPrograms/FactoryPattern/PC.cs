/*using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.FactoryPattern
{

    public class PC : Computer
    {
        private string RAM;
        private string HDD;
        private string CPU;

        public PC(string ram, string hdd, string cpu)
        {
            Ram = ram;
            Hdd = hdd;
            Cpu = cpu;
        }
        public string Ram { get; set; }
        public string Hdd { get; set; }
        public string Cpu { get; set; }

    }
    public override Computer GetComputer()
    {
        return new PC(RAM, HDD, CPU);
    }
}
*/