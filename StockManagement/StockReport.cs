// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockReport.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.StockManagement
{
    class StockReport
    {
        public void InputStock()
        {
            PropertyClass PropertyObj = new PropertyClass();
            try
            {
                Console.WriteLine("Enter a Name of the Share");
                PropertyObj.NameOfShare = Console.ReadLine();
                Console.WriteLine("Enter Enter a Number of Share");
                PropertyObj.NumberOfShare = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Share Price ");
                PropertyObj.SharePrice = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occurs.." + e.Message);
            }
        }
    }
}
