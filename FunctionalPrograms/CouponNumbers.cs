// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CouponNumbers.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class CouponNumbers
    {
        /// <summary>
        /// Generates the coupons.
        /// </summary>
        public static void CouponGenerator()
        {
            Console.WriteLine("How many Distinct Coupon Codes Do you Want Generate?");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input + " Distinct Coupon Codes are: ");

            Util.Coupons(input);
        }
    }
}

