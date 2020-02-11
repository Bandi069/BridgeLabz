using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
/// <summary>
/// 
/// </summary>
namespace DataStructures
{
    class Hashing
    {/// <summary>
    /// 
    /// </summary>
        public void HashingTable()
        {
            Console.WriteLine("Hashing Table");
            string[] array;
            StreamReader reader = new StreamReader(@"C:\Users\Bridge Labs\source\repos\DataStructures\DataStructures\HashTextFile.txt");
            string str;
            str = reader.ReadLine();
            try
            {
                if (str != null)
                {
                    array = str.Split(" ");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(array[i]);
                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
