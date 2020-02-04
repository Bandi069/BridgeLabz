using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Node<T>
    {
        public Object data;
        public Node<T> next;
        public Node<T> front;
        public Node<T> rear;

        public Node<T> Prev;

        public Node(T data)
        {
            this.data = data;
            this.next = null;
            this.front = null;
            this.rear = null;
            this.Prev = null;
        }

    }
}
