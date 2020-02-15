using DesignPatternPrograms.StructuralDesignPaytterns.ProductFacadeDesignPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.StructuralDesignPaytterns.CarFacadeDesignPattern
{
   public class CarFacade
    {
        CarModel ModelObj = new CarModel();
            CarBody BodyObj = new CarBody();
            CarEngine EngineObj = new CarEngine();
        public void carfade()
        {
            ModelObj.Model();
            BodyObj.Body();
            EngineObj.Engine();
        } 
      
      
    }
}
