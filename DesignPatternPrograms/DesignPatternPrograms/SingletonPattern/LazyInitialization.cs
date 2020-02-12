using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.SingletonPattern
{
    class LazyInitialization
    {
        private static readonly Lazy<LazyInitialization> SingletonObj = 
            new Lazy<LazyInitialization>(() => new LazyInitialization());

    }
}
