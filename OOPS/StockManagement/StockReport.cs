<<<<<<< HEAD
﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockReport.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
=======
﻿using System;
>>>>>>> 0719d6bd675447eb14e05ecd50c0f34251333d15
using System.Collections.Generic;
using System.Text;

namespace OOPS.StockManagement
{
    class StockReport
    {
<<<<<<< HEAD
=======
        public int NameOfShare { get;  set; }
        public string SharePrice { get; set; }
        public string NumberOfShare { get;  set; }

>>>>>>> 0719d6bd675447eb14e05ecd50c0f34251333d15
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
<<<<<<< HEAD
                Console.WriteLine("Exception Occurs.." + e.Message);
            }
=======
                Console.WriteLine("Exception Occurs" + e.Message);
            }

        }
        public  void MethodsCalling()
        {
            StockPortfolio Stockobj = new StockPortfolio();
            Stockobj.Stock();
            Stockobj.AddStock();

>>>>>>> 0719d6bd675447eb14e05ecd50c0f34251333d15
        }
    }
}
