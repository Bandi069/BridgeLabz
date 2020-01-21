using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" **************** ");
            Console.WriteLine("1. Permutation With Iteration");
            Console.WriteLine("2. Word Search in file using Binary Search");
            Console.WriteLine("3. Perform insertion Sort");
            Console.WriteLine("4. Perform Bubble Sort");
            Console.WriteLine("5. Perform Merge Sort");
            Console.WriteLine("6. Print the given string is anagram or not");
            Console.WriteLine("7. Print Prime Numbers In the given range");
            Console.WriteLine("8. Print Prime Numbers with Anagram and anagram");
            Console.WriteLine("9. ");
            Console.WriteLine("10.Guess the Number in the given range");

            Console.WriteLine(" *************** ");
            Console.WriteLine("\n");
            Console.WriteLine("Enter Your Choice : ");

            int Choice = Utility.UserInput();
            switch (Choice)
            {
                case 1:
                Permutations pm=new Permutations();
                    pm.getPermute();                                
                break;
                case 2:
                    WordBinarySearch.BinarySearchFile();
                    break;
                case 3:
                    InsertionSort.InesrtionSorting();
                    break;
                case 4:
                    BubbleSort.BubbleSorting();
                    break;
                case 5:
                    MergeSort.MergeSorting();
                    break;
                case 6:
                    Anagram.CheckAnagram();
                    break;
                case 7:
                     PrimeNumbers.PrintPrime();
                    break;
                case 8:
                    PrimeAnagram.PrimeAnagramPalindrome();
                    break;
                case 9:
                    break;
                case 10:
                    NumberGuessing.GuessNumber();
                    break;

            }
        }          
    }   
}
