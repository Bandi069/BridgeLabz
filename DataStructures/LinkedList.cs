using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
 /// <summary>
 /// Performing Unorder List Operations 
 /// Methods for different operations 
 /// </summary>
    class LinkedList
    {
        /// <summary>
        /// Nodes adding to a file using a new Method 
        /// </summary>
        public Node head = null;
        public void AddNode(string s)
        {
            Node newnode = new Node(s);
            if (head == null)
            {
                head = newnode;
            }
            else
            {
              
                head.next = newnode;
                newnode = head;
            }
            //// Calling Display method
            Display();
        }
        /// <summary>
        /// A method to display the file 
        /// </summary>
        public void Display()
        {
            Node CurrentNode = head;
           
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
                
                Console.WriteLine(CurrentNode.data + " ");
            }

        }
        /// <summary>
        /// Creating a new method for removing item 
        /// </summary>
        /// <param name="removeitem"></param>
        public void RemoveItem(String removeitem)
        {
            Node temp = head;
            Node Prev = null;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (temp != null )
                {
                    if (temp.data == removeitem)
                    {
                        Prev=temp.next;
                        temp = null;
                        Console.WriteLine("Found and Deleted input Item");
                        return;
                    }
                      Prev = temp.next;
                    temp = null;
                }

            }
            //// Calling Display method 
            //// Display the file content after removing item 
           Display();
        }
        //// Boolean value 
        bool statement = false;
        /// <summary>
        /// method to search the given item in the list
        /// </summary>
        /// <param name="Searchitem"></param>
        
        public bool Search(string Searchitem)
        {
            
            Node temp = head;
            if (head==null)
            {
                Console.WriteLine("Node not found...List is Empty");
                statement = true;
            }
           
            else if(temp.data==Searchitem)
            {
                statement = true;
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data.Equals(Searchitem))
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
        /// Method to give the list is empty or not 
        /// </summary>
        
        public bool isEmpty()
        {
            if(head == null)
            {
                statement = true;
                return statement;
            }
            else
            {
                return statement;
            }

        }
        /// <summary>
        /// Method to find the Size of list 
        /// </summary>
        
        public int size()
        {
            int count = 0;
            if (head == null)
            {
                return count;
            }
            while(head !=null)
            {
                count++;
                head = head.next;
            }
            return count;
        }
        /// <summary>
        /// Method to append a new item
        /// append a new item at the end of the list
        /// Making the aapend new item as last in the list
        /// </summary>
        /// <param name="newitem"></param>
        
        public bool AppendNode(string newitem)
        {
            Node appendnode = new Node(newitem);
            if(head == null )
            {
                head = appendnode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = head;
            }
            return statement;
            
        }
        /// <summary>
        /// Method to find index of item 
        /// It gives the index value of the item in the list
        /// </summary>
        /// <param name="item"></param>

        public int index(string item)
        {
            Node currentNode = head;
            int count = 0;
            if (currentNode.data == null)
            {
                return -1;
            }
            while(currentNode.data != null)
            {
                currentNode = currentNode.next;
                count++;
            }
            return count;

        }
        

    }
}
