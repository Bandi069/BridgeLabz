using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// Creating a Node class 
    /// it gives a Node Values when function calls
    /// </summary>
    class Node
    {
      public  Object data;
      public  Node next;
        /// <summary>
        /// Creating a method for Node
        /// </summary>
        /// <param name="data"></param>
        public Node(Object data)
        {
            this.data = data;
            this.next = null;
        }
               
    }
}
