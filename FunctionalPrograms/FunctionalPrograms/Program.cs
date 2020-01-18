using System;

namespace FunctionalPrograms
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Choice");
			int choice = int.Parse(Console.ReadLine());
			switch (choice)
			{
				case 1:
					UserStringName.StringReplace();
					break;
				case 2:
					Factorial.FactValue();
					break;
				case 3:
					LeapYear.CheckLeapYear();
					break;
				case 4:
					PowerTwo.FindPower();
					break;
				case 5:
					Harmonic.HarmonicValue();
					break;
				case 6:
					FlipCoin.FlipPercent();
					break;
				case 7:
					TempConversion.TempCon();
					break;
				case 8:
					Sqrt.FindSquare();
					break;
				case 9:
					Array2D.PrintArray();
					break;
				case 10:
					StopWatch Stop = new StopWatch();
					Stop.Watch();
					break;
				case 11:
					Distance.CalculateDistance();
					break;
				case 12:
					Quadratic.FindRoots();
					break;
				case 13:
					WindChill.FindWindChill();
					break;
				case 14:
					TripleZero.SumZeroTriple();
					break;
				case 15:
					DayofWeek.WeekDay();
					break;
				case 16:
					MonthlyPayment.MoneyEMI();
					break;
				case 17:
					Gambler.Gambling();
					break;
				case 18:
					CouponNumber.CheckCoupon();
					break;
				case 19:
					VendingMechine.CountingMachine();
					break;
				case 20:
					DecimalBinary.ToBinary();
					break;
				case 21:
					//BinaryConversion.BinaryNibbleSwap();
						break;
			}
		}
	}
}
