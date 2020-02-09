﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Calender.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// Calender Class to print Calender
    /// </summary>
    class Calender
    {
        /// <summary>
        /// Calenders this instance.
        /// </summary>
        public void calender()
        {
            Console.WriteLine("Enter year ");
            int year = Utility.UserIntInput();
            Console.WriteLine("Enter Month");
            int month = Utility.UserIntInput();
          //int[ , ] CalenderArray = new int[6, 7];
            int[] Days = new int[]{ 0,31,28,31,30,31,30,31,31,30,31,30,31 };
            string[] months = {"","January", "February", "March","April", "May", "June",
                "July", "August", "September", "October", "November", "December" };
            if (LeapYear(year))
            {
                Days[2] = 29;
            }
            Console.WriteLine(months[month] + "-" + year);
            Console.WriteLine("Sun  Mon Tues  Weds Thurs  Fri  Sat");
            int d = day(month, 1, year);
            for (int i=0;i<=d;i++)
            {
                Console.Write(" ");
            }
            for (int i = 1; i <= Days[month]; i++)
            {
                
                Console.Write(i+"   ");
                if (((i+d) % 7 == 0) || (i == Days[month]))
                {
                    Console.WriteLine(" ");
                 }
            }

        }
        /// <summary>
        /// Leaps the year.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns value="LeapYear"></returns>
        public bool LeapYear(int year)
        {
            bool leapyear = false;
            if((year%400==0)||(year%100==0) && (year%4==0))
            {
                leapyear = true;
            }
            else
            {
                leapyear = false;
            }
            return leapyear;
        }
        /// <summary>
        /// Days the specified month.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns value="d"></returns>
        public int day(int month, int day, int year)
        {
            int y = year - (14 - month) / 12;
            int x = y + y / 4 - y / 100 + y / 400;
            int m = month + 12 * ((14 - month) / 12) - 2;
            int d = (day + x + (31 * m) / 12) % 7;
            return d;
        }

    }
}
