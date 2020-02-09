// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeQueue.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class DeQueue<T>
    {
        public Node<T> head = null;
        public Node<T> front = null;
        public Node<T> rear = null;
        public Node<T> current = null;
        int size = 0;
        string str = " ";
        /// <summary>
        /// Adds the rear.
        /// Adding character at Rear
        /// </summary>
        /// <param name="Character">The character.</param>
        public void AddRear(T Character)
        {
            Node<T> newNode = new Node<T>(Character);
            if (head == null)
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
        /// <summary>
        /// Adds the front.
        /// adding character at front
        /// </summary>
        /// <param name="Character">The character.</param>
        public void addFront(T Character)
        {
            Node<T> Prev = null; ;
            Node<T> newnode = new Node<T>(Character);
            if (front == null)
            {
                front = newnode;
            }
            else
            {
                newnode.next = front;
                front.Prev = newnode;
                front = newnode;
            }
        }
        /// <summary>
        /// Displays this instance.
        /// Method for Display the Queue
        /// </summary>
        public void Display()
        {
            Node<T> CurrentNode = head;
            if (front == null)
            {
                Console.WriteLine("Dequeue list is empty");
            }
            else
            {
                while (rear != null)
                {
                    str = str + rear.data;
                    rear = rear.next;
                }
            }

        }
        /// <summary>
        /// Removes the front.
        /// </summary>
        /// <returns></returns>
        public string RemoveFront()
        {
            Node<T> prev;
            if (front == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                char Character = (char)rear.data;
                prev = front;
                front = front.next;
                prev = null;
                Console.WriteLine(Character.ToString());
            }
            return null;
        }
        /// <summary>
        /// Removes the rear.
        /// </summary>
       
        public string RemoveRear()
        {
            Node<T> Prevnode;
            if(rear==null)
            {
                Console.WriteLine("queue is empty");
            }
            else
            {
                char Character = (char)rear.data;
                Prevnode=rear;
                rear = rear.Prev;
                Prevnode = null;
                Console.WriteLine(Character.ToString());
            }
            return null;
        }
        /// <summary>
        /// Prints the polindrime.
        /// </summary>
        /// <returns ></returns>
        public bool printPolindrime()
        {
            string str1 = "radar";
            string str2 = "radar";
            bool polistatus = false;
            
            return true;
        }

    }
}
