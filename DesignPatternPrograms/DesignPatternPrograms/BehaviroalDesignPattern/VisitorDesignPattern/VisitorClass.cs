using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviroalDesignPattern.VisitorDesignPattern
{
    public interface IVisitor
    {
        public int Visit(Book book)
        {
            int cost = 0;
            return cost;
        }
        public int Visit(Fruit fruit);
    }
    public interface IitemElement
    {
        public int Accept(IVisitor visitor);
    }
    
    public class Fruit
    {

    }
}
