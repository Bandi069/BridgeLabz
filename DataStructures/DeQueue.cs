using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class DeQueue<T>
    {
        public Node<T> head = null;
        public Node<T> front = null;
        public Node<T> rear = null;
        public Node<T> current = null;
        int size = 0;
        string str = " ";
        public void AddRear(T Character)
        {
            Node<T> newNode = new Node<T>(Character);
            if(head == null)
            {
                front = newNode;
            }
            else
            {
                front.next = newNode;
                newNode.rear = front;
                rear = newNode;
            }
            Display();
            size++;
        }
        public void addFront()
        {

        }
        public void Display()
        {
            Node<T> CurrentNode = head;
            if(front ==null)
            {
                Console.WriteLine("Dequeue list is empty");
            }
            else
            {

            }
        }

    }
}
