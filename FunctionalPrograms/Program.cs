using System;

namespace FunctionalPrograms
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("************************************\n");
			Console.WriteLine("1.String Replace Program");
			Console.WriteLine("2.Factorial Program ");
			Console.WriteLine("3.To find the leap year ");
			Console.WriteLine("4.Power of Two program ");
			Console.WriteLine("5.Harmonic series program ");
			Console.WriteLine("6. FlipCoin Program	");
			Console.WriteLine("7.Temperature Conversion Program");
			Console.WriteLine("8.Square root of a number ");
			Console.WriteLine("9.Printing Two dimensional Array in C# ");
			Console.WriteLine("10.Stop watch Program");
			Console.WriteLine("11.Distance calculation ");
			Console.WriteLine("12. Finding roots of Quadratic equation  Program");
			Console.WriteLine("13.Windchill Program ");
			Console.WriteLine("14.Triplet Program ");
			Console.WriteLine("15.Finding the day of the week ");
			Console.WriteLine("16.Finding Monthly Payment Program ");
			Console.WriteLine("17. Gambler Program");
			Console.WriteLine("18.Coupon number Program ");
			Console.WriteLine("19.Vending Machine Program ");
			Console.WriteLine("20.  Decimal to Binary Conversion Program ");
			Console.WriteLine("21. Tictoctoe Program ");
			Console.WriteLine("22.Binary Nibble Swapping Program \n");
			Console.WriteLine("************************************\n");
			
			Console.WriteLine("Enter Choice to implement the required Program \n");
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
					TicTocToe.initBoard();
					break;

				case 22:
					//BinaryConversion.BinaryNibbleSwap();
						break;
			}
		}
	}
}
