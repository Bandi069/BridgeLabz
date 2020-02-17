using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviroalDesignPattern.VisitorDesignPattern
{
    public class Book : IitemElement
    {
        private int Price;
        private string isbnNumber;
        public Book(int cost, string isbnNumber)
        {
            this.Price = cost;
            this.isbnNumber = isbnNumber;
        }
        public int GetPrice()
        {
            return Price;
        }
        public string GetisbnNumber()
        {
            return isbnNumber;
        }
        public int Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
    public class Fruit : IitemElement
    {
        private int PriceperKg;

        private int weight;
        private string FruitName;
        public Fruit(int PricepeKg,int Weight,string FruitName)
        {

        }

        public int Accept(IVisitor visitor)
        {
            return Getprice(this);
        }
    }
}
