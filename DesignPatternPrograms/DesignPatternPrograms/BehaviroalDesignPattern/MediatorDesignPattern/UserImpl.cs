// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserImpl.cs" company="Bridgelabz">
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
    /// This is UserImpl Class
    /// </summary>
    public class UserImpl : UserMediator
    {
        public string name;

        public UserImpl(ChatMediator msg, string name) : base(msg, name) { }
        /// <summary>
        /// This is send method for message
        /// </summary>
        /// <param name="msg"></param>
       override
        public void Send(string msg)
        {
            Console.WriteLine(this.name +"Messge sending :"+msg);
        }
        /// <summary>
        /// This is Receive method for message
        /// </summary>
        /// <param name="msg"></param>
        override
        public void Receive(string msg)
        {
            Console.WriteLine(this.name + "Recieve messgae :" + msg);
        }
    }
}
