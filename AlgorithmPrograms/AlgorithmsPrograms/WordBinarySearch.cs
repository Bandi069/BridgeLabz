using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AlgorithmPrograms
{
    class WordBinarySearch
    {
        public static void BinarySearchFile()
        {
                     
            Console.Write("Enter Input Value :");
            String input = Utility.InputString();
            try
            {
                StreamReader reader;
                 reader = new StreamReader(@"C:\Users\tree\Desktop\FirstText.txt");
                String Str = reader.ReadLine();
                Console.WriteLine(Str);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
