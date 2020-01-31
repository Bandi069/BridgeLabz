using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructures
{
    class OrderedList
    {
       
        string[] array;
        public void orderedlist()
        {
            OrderLinkedList OrderList = new OrderLinkedList();
            string str;
            try
            {
                StreamReader read;
                read = new StreamReader(@"C:\Users\Bridge Labs\Desktop\New folder\Numberfile.txt");

                if ((str = read.ReadLine()) != null)
                {
                    array = str.Split(" ");
                    int[] arr = new int[array.Length];
                    //// Printing elements in the file 
                    for (int i = 0; i < array.Length; i++)
                    {
                        arr[i] = Convert.ToInt16(array[i]);
                        // arr[i] = int.Parse(array[i]);
                    }
                    Array.Sort(arr);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine(arr[i] + " ");
                    }
                }

                Console.WriteLine("Enter a Number to add to list");
                int number = Utility.UserIntInput();
                OrderList.additem(number);

                Console.WriteLine("Enter number to add to list");
                int removeitem = Utility.UserIntInput();
                OrderList.RemoveItem(removeitem);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
