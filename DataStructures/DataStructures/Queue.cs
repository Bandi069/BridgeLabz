using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// Banking trasnction performing using Queue list
    /// Performing different Queue and Dequeue Operations
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Queue<T>
    {
        /// <summary>
        /// Initializing Balance of Bank and Nodes
        /// </summary>
        int AccountBalance = 500000;
        public Node<T> front = null;
        public Node<T> rear = null;
        public Node<T> current = null;
        int size = 0;
        /// <summary>
        /// Method to Add customers in a queue 
        /// </summary>
        /// <param name="Name"></param>
        public void AddingQueue(T Name)
        {
            //// creating new Node object 
            Node<T> newNode = new Node<T>(Name);
            if (front == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
            size++;

        }
        /// <summary>
        /// Method for Dequeue Operation
        /// Removing customers in the queue
        /// </summary>
        public void Dequeue()
        {
            Node<T> Current;
            if (front == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                while (front != null)
                {
                    string str = (string)front.data;
                    Console.WriteLine("Name of Customer" + str);
                    Console.WriteLine("Enter the choice for transaction \n 1. Deposit Amount \n 2. Withdrawal Amount");
                    int choice = Utility.UserIntInput(); //// User Input from Utility Class
                    switch (choice)
                    {
                        //// Case1 operation for Deposit amount in bank
                        case 1:
                            Console.WriteLine("Enter Amount to Deposit");
                            int Deposite = Utility.UserIntInput();
                            ////Calling a Method for Deposte amount
                            Depositamount(str, Deposite);
                            Console.WriteLine("Customer Name :" + str + "\tDeposite Amount" + Deposite);
                            Console.WriteLine("Bank Account Balance :" + AccountBalance);
                            break;
                        //// Case 2 operation for Withdraw Amount From Bank
                        case 2:
                            Console.WriteLine("Enter Withdraw Amount ");
                            int Withdrawamount = Utility.UserIntInput();
                            //// Calling a Method for Withdrawal 
                            WithdrawAmount(str, Withdrawamount);
                            Console.WriteLine("CustomerName :" + str + "\tWithdraw Amount :" + Withdrawamount);
                            Console.WriteLine("Bank Account Balance :" + AccountBalance);
                            break;
                        default:
                            //// Default Case
                            Console.WriteLine("Invalid Transction Type");
                            break;

                    }
                    Current = front;
                    front = front.next;
                    Current = null;
                }

            }
        }
        /// <summary>
        /// Method for calculating Bank Balance by giving Deposit amount 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="Depamount"></param>
        /// <returns AccountBalance></returns>
        public int Depositamount(String str, int Depamount)
        {
            int amount = 0;
            amount = amount + Depamount;
            AccountBalance = AccountBalance + Depamount;
            return AccountBalance;
        }
        /// <summary>
        /// Method for calculating Bank Balance by giving Withdrawal amount 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="Withdrawamount"></param>
        /// <returns AccountBalance></returns>
        public int WithdrawAmount(String str, int Withdrawamount)
        {
            int amount = 0;
            amount = amount + Withdrawamount;
            AccountBalance = AccountBalance - Withdrawamount;

            return AccountBalance;
        }


    }
}

