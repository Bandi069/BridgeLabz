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
            if(book.GetPrice()>50)
            {
                cost = book.GetPrice() - 10;
            }
            else
            {

            }
            return cost;
        }
        public int Visit(Fruit fruit);
    }
    public interface IitemElement
    {
        public int Accept(IVisitor visitor);
    }
    public class ShoppingVisit : IVisitor
    {
        public int Visit(Book book)
        {

        }

        public int Visit(Fruit fruit)
        {
            throw new NotImplementedException();
        }
    }



}
