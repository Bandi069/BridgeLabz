using System;
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
            RAM = ram;
            HDD = hdd;
            CPU = cpu;
        }
    }
}
