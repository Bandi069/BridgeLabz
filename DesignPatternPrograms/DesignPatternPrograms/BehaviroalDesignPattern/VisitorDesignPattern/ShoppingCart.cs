// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShoppingCart.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviroalDesignPattern.VisitorDesignPattern
{
    /// <summary>
    /// This is Shopping Cart Class
    /// </summary>
    public class ShoppingCart : IVisitor
    {
        /// <summary>
        /// Constructor for Shopping cart class
        /// </summary>
        public ShoppingCart()
        {
            Console.WriteLine("This is Shopping Cart");
        }
        /// <summary>
        /// This is Visit Method for Book
        /// </summary>
        /// <param name="book"></param>
        /// <returns value="cost"></returns>
        public int Visit(Book book)
        {
            Visit visitObj = new Visit();
            int cost ;
            if (book.GetPrice() > 50)
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
        /// <summary>
        /// This is for visits method for Fruit 
        /// </summary>
        /// <param name="fruit"></param>
        /// <returns value="cost"></returns>
        public int Visit(Fruit fruit)
        {
            int cost = fruit.GetPrice() * fruit.GetWeight();
            Console.WriteLine("Fruit Name is :" + fruit.GetName() + "Cost is :" + cost);
            return cost;
        }

    }

    public class Visit
    {
       
    }
}
