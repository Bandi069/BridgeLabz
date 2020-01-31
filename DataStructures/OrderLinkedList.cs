using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class OrderLinkedList
    {
        public Node head = null;
        public void additem(int n)
        {
            Node newnode = new Node(n);
           Node temp = head;
            if (head == null)
            {
                head = newnode;
            }
            else
            {
                head.next = newnode;
              
            }
            Display();
        }
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
                 Console.WriteLine(CurrentNode.data +" ");
            }
        }
        public void RemoveItem(int removeitem)
        {
            Node temp = head;
            Node Prev = null;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (temp != null)
                {
                   //if (temp.data==removeitem )
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

    }
}
