using DesignPatternPrograms.StructuralDesignPaytterns.ProductFacadeDesignPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.StructuralDesignPaytterns.CarFacadeDesignPattern
{
    /// <summary>
    /// This is CarFacade Design pattern
    /// </summary>
    public class CarFacade
    {
        //// Creating Objects in Gobval
        /// <summary>
        /// This is Car Model Object
        /// </summary>
        CarModel ModelObj = new CarModel();
        /// <summary>
        /// This is car Body Object
        /// </summary>
        CarBody BodyObj = new CarBody();
        /// <summary>
        /// This is car Engine Object
        /// </summary>
        CarEngine EngineObj = new CarEngine();
       /// <summary>
       /// This is method for Facade of car
       /// </summary>
        public void carfade()
        {
            Console.WriteLine("Hi,\nHere the Accesries of car");
            ModelObj.Model();////Calling model through its object
            BodyObj.Body(); ////Calling Body though its Object
            EngineObj.Engine();//// calling Engine method though its Object
        }


    }
}
