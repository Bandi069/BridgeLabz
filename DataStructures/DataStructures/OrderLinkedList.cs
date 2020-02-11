using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// Implementation of Orederd List
    /// Performed Various types of operations  
    /// Reading Numbers from a text file 
    /// </summary>
    class OrderLinkedList
    {
        /// <summary>
        /// Method to add the numbesrs in the list
        /// </summary>
        public Node1 head = null;
        public void additem(int number)
        {
            //// Creating Node object
            Node1 newnode = new Node1(number);
           Node1 temp = head;
            //// Adding new Nodes to list
            if (head == null)
            {
                head = newnode;
            }
            else
            {
                head.next = newnode;
              
            }
            //// Calling display method
            Display();
        }
        /// <summary>
        /// Method to display the list
       /// </summary>
        public void Display()
        {
            Node1 CurrentNode = head;

            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (CurrentNode.next != null)
                {
                    CurrentNode = CurrentNode.next;
                }
                 Console.WriteLine(CurrentNode.data +" ");
            }
        }
        /// <summary>
        /// Creating a new method for removing item 
        /// </summary>
        /// <param name="removeitem"></param>
        public void RemoveItem(int removeitem)
        {
            Node1 temp = head;
            Node1 Prev = null;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (temp != null)
                {

                    if (temp.data == removeitem)
                    {
                        Prev = temp.next;
                        temp = null;
                        Console.WriteLine("Found and Deleted input Item");
                        return;
                    }
                    Prev = temp.next;

                }

            }
        }
        bool statement = false;
        /// <summary>
        /// Method to search an element in the list
        /// Searching element is given by user input 
        /// </summary>
        /// <param name="Searchnumber"></param>
        /// <returns statement></returns>
        public bool Search(int Searchnumber)
        {

            Node1 temp = head;
            if (head == null)
            {
                Console.WriteLine("Node not found...List is Empty");
                statement = true;
            }
                       
            else
            {
                while (temp != null)
                {
                    if (temp.data.Equals(Searchnumber))
                    {
                        Console.WriteLine("item Found in the list");
                        statement = true;
                    }
                    temp = temp.next;
                    temp.next = null;
                }
            }
            Display();
            return statement;
        }
        /// <summary>
        /// Method to print size of the list
        /// </summary>
        /// <returns count></returns>
        public int size()
        {
            int count = 0;
            if (head == null)
            {
                return count;
            }
            while (head != null)
            {
                count++;
                head = head.next;
            }
            return count;
        }
        /// <summary>
        /// Method to give the index value 
        /// of given input number in the list
        /// </summary>
        /// <param name="indexvalue"></param>
        /// <returns count></returns>
        public int index(int indexvalue)
        {
            Node1 currentNode = head;
            int count = 0;
            if (currentNode.data == null)
            {
                return -1;
            }
            while (currentNode.data != null)
            {
                currentNode = currentNode.next;
                count++;
            }
            return count;

        }

    }
}
