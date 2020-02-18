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
    public class UserImpl : UserMediator
    {
        public string name;

        public UserImpl(ChatMediator msg, string name) : base(msg, name) { }
       override
        public void Send(string msg)
        {
            Console.WriteLine(this.name +"Messge sending :"+msg);
        }
        override
        public void Receive(string msg)
        {
            Console.WriteLine(this.name + "Recieve messgae :" + msg);
        }
    }
}
