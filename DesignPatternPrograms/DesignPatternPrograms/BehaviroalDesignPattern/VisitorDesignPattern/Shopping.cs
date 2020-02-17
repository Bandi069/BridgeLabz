// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Shopping.cs" company="Bridgelabz">
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
    /// This is Shopping Class 
    /// </summary>
   public class Shopping : ShoppingCart
    {
        /// <summary>
        /// Book variable is declaring as global
        /// </summary>
        private Book book;
        /// <summary>
        /// Method for Shopping 
        /// </summary>
        public void MethodShopping()
        {
            //// Declartaion of new  Elements  
            IitemElement[] items = new IitemElement[]
            {
                new Book(20,"1234"),
                new Fruit(5,10,"Banana")
            };
            int total = CalculatePrice(items);
            Console.WriteLine("Total Price" + total);
        }
        /// <summary>
        /// This is a Method for Caclulation of price
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public  int CalculatePrice(IitemElement[] items)
        {
            int totalprice = 0;
            //// Creating Object for Shopping Cart
            ShoppingCart  VisitObj = new ShoppingCart();
            VisitObj.Visit(book);
           
            foreach(IitemElement item in items)
            {
                totalprice = totalprice + item.Accept(VisitObj);
            }
            return totalprice;
        }

       
    }
}
