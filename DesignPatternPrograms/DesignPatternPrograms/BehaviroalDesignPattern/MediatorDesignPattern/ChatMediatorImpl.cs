// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatMediatorImpl.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviroalDesignPattern.MediatorDesignPattern
{
    /// <summary>
    /// This is Chatmediatorimpl class
    /// </summary>
    public class ChatMediatorImpl : ChatMediator
    {
        /// <summary>
        /// This is users List
        /// </summary>
        public List<UserMediator> users;
        /// <summary>
        /// This is ChatMediatorImpl Constructor 
        /// </summary>
        public ChatMediatorImpl()
        {
            this.users = new List<UserMediator>();

        }
        /// <summary>
        /// This is method for AddUser
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(UserMediator user)
        {
            this.users.Add(user);
        }
        /// <summary>
        /// This is method for Message
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="user"></param>
        public void Message(string msg, UserMediator user)
        {
            foreach (UserMediator userin in this.users)
            {
                if (userin != user)
                {
                    userin.Receive(msg);
                }
            }
        }
    }
}
