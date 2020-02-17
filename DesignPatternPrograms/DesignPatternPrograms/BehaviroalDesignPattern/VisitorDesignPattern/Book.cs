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
        public Fruit(int Price,int weight,string Name)
        {
            this.PriceperKg = Price;
            this.weight = weight;
            this.FruitName = Name;
        }
        public int GetPrice()
        {
            return PriceperKg;
        }
        public int GetWeight()
        {
            return weight;
        }
        public string GetName()
        {
            return FruitName;
        }

        public int Accept(IVisitor visitor)
        {
            return GetPrice();
        }
    }
}
