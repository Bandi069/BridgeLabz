using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviroalDesignPattern.VisitorDesignPattern
{
   public class Book
    {
        private int Price;
        private string isbnNumber;
        public Book(int cost,string isbnNumber)
        {
            this.Price = cost;
            this.isbnNumber = isbnNumber;
        }

    }
}
