// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Book.cs" company="Bridgelabz">
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
    /// This is class for Book
    /// </summary>
    public class Book : IitemElement
    {
        /// <summary>
        /// This is int value of Price
        /// </summary>
        private int Price;
        /// <summary>
        /// this is string isbnNumber 
        /// </summary>
        private string isbnNumber;
        /// <summary>
        /// Book Instance for Cost and isbnNumber
        /// </summary>
        /// <param name="cost"></param>
        /// <param name="isbnNumber"></param>
        public Book(int cost, string isbnNumber)
        {
            this.Price = cost;
            this.isbnNumber = isbnNumber;
        }
        /// <summary>
        /// This is method for GetPrice
        /// </summary>
        /// <returns></returns>
        public int GetPrice()
        {
            return Price;
        }
        /// <summary>
        /// This is method for get isbnNumber
        /// </summary>
        /// <returns></returns>
        public string GetisbnNumber()
        {
            return isbnNumber;
        }
        /// <summary>
        /// This is method fot Accept Visitor
        /// </summary>
        /// <param name="visitor"></param>
        /// <returns></returns>
        public int Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
    /// <summary>
    /// This is Fruit class 
    /// </summary>
    public class Fruit : IitemElement
    {
        /// <summary>
        /// This is Private int variable of Priceperkg
        /// </summary>
        private int PriceperKg;
        /// <summary>
        /// This is Private int variable of Weight
        /// </summary>
        private int weight;
        /// <summary>
        /// This is private string variable
        /// </summary>
        private string FruitName;
        /// <summary>
        /// This is Constructor of fruit class
        /// </summary>
        /// <param name="Price"></param>
        /// <param name="weight"></param>
        /// <param name="Name"></param>
        public Fruit(int Price, int weight, string Name)
        {

            this.PriceperKg = Price;
            this.weight = weight;
            this.FruitName = Name;
        }
        /// <summary>
        /// This is method for getprice
        /// </summary>
        /// <returns></returns>
        public int GetPrice()
        {
            return PriceperKg;
        }
        /// <summary>
        /// This is method for return Weight
        /// </summary>
        /// <returns></returns>
        public int GetWeight()
        {
            return weight;
        }
        /// <summary>
        /// This is method for  return name 
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return FruitName;
        }
        /// <summary>
        /// This is Accept visitor method to return the value
        /// </summary>
        /// <param name="visitor"></param>
        /// <returns></returns>
        public int Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
