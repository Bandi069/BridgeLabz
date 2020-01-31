using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataStructures
{
    class UnOrderedList
    {
        /// <summary>
        /// Implementation of UnOrederd List
        /// Performed Various types of operations  
        /// Reading the Text from a file 
        /// split it into words and arranged it as Linked List
        /// </summary>
        public void UnorderList()
        {
            String[] array;
            LinkedList List = new LinkedList();
            StreamReader reader; 
            try
            {
                //// reading values from a file through stream reader path
                reader = new StreamReader(@"C:\Users\Bridge Labs\Desktop\textfile.txt");
                string str;
                str = reader.ReadLine();
                if (str != null)
                {
                    array = str.Split(" ");
                    //// Printing elements in the file 
                    for(int i=0; i<array.Length; i++)
                    {
                         Console.WriteLine(array[i]);
                    }

                   foreach(string str1 in array)
                    {
                        List.AddNode(str1);
                   }
                   //// Element to add in the list
                    Console.WriteLine("Enter a item to insert an item to list");
                    string Insertitem = Utility.UserStringInput();
                    List.AddNode(Insertitem);

                    //// Removing item from the List
                    Console.WriteLine("Enter item to delete");
                    string Removeitem = Utility.UserStringInput();
                    List.RemoveItem(Removeitem);

                    //// Item Searching in list
                    Console.WriteLine("Enter a Item to search In the List");
                    string Searchitem = Utility.UserStringInput();
                    List.Search(Searchitem);

                    //// printing list is empty or not
                    Console.WriteLine(List.isEmpty());

                    //// Printing Size of List
                    Console.WriteLine(List.size());

                    //// adding new item to list at end
                    Console.WriteLine("Enter a item to append");
                    string newitem = Utility.UserStringInput();
                    Console.WriteLine(List.AppendNode(newitem));

                    ////Finding value at the given Index Positin
                    Console.WriteLine("Enter a index value to get position");
                    string indexvalue = Utility.UserStringInput();
                    List.index(indexvalue);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
