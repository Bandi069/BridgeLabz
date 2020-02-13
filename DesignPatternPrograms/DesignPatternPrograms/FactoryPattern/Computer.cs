using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.FactoryPattern
{
    public abstract class Computer 
    {

        public string RAM { get; set; }
        public string HDD { get; set; }
        public string CPU { get; set; }
    }
}
