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
                cost = book.GetPrice();
            }
            Console.WriteLine("Book cost is :" + cost);
            return cost;
        }
        public int Visit(Fruit fruit)
        {
            int cost = fruit.GetPrice();
            return cost;
        }
    }
    public interface IitemElement
    {
        public int Accept(IVisitor visitor);
    }
   



}
