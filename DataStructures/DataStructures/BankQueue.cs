using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BankQueue
    {
        public void Bankqueue()
        {
            Queue<string> queuelist = new Queue<string>();
            Console.WriteLine("Enter no of candidates in the Queue");
            int Numbers = Utility.UserIntInput();
            for(int i=0;i<Numbers;i++)
            {
                Console.WriteLine("Enter the name of Customer");
                string Name = Utility.UserStringInput();
                queuelist.AddingQueue(Name);
            }
            queuelist.Dequeue();
           /* Console.WriteLine("Enter the Amount");
            int AccountBalance = Utility.UserIntInput();*/
        }

    }
}
