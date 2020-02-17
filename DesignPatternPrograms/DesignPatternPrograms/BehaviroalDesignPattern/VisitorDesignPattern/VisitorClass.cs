using DesignPatternPrograms.BehaviroalDesignPattern.VisitorDesignPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviroalDesignPattern
{
    /// <summary>
    /// This is Interface for IVisitor
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// This is Visitbook method
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int Visit(Book book);
        /// <summary>
        /// This is method of Fruits 
        /// </summary>
        /// <param name="fruit"></param>
        /// <returns></returns>
      
        public int Visit(Fruit fruit);
       
    }
    /// <summary>
    /// This is  interface for IitemElement
    /// </summary>
    public interface IitemElement
    {
        /// <summary>
        /// This is IVisitor method of Interface
        /// </summary>
        /// <param name="visitor"></param>
        /// <returns></returns>
        public int Accept(IVisitor visitor);
    }
    
    

}
