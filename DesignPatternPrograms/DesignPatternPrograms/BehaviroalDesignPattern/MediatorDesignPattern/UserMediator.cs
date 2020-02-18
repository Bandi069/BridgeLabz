// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserMEdiator.cs" company="Bridgelabz">
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
    /// This is Abstract class for UserMediator
    /// </summary>
    public abstract class UserMediator
    {
        /// <summary>
        /// Chat mediator instance
        /// </summary>
        public ChatMediator mediator;
        /// <summary>
        /// String Name
        /// </summary>
        public string Name;
        /// <summary>
        /// This is UserMediator Constructor
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="name"></param>
        public UserMediator(ChatMediator msg, String name)
        {
            this.mediator = msg;
            this.Name = name;
        }
        /// <summary>
        /// This is Abstract method for Send
        /// </summary>
        /// <param name="msg"></param>
        public abstract void Send(string msg);
        /// <summary>
        /// This is Abstract Receieve Message
        /// </summary>
        /// <param name="msg"></param>
        public abstract void Receive(string msg);

    }
}
