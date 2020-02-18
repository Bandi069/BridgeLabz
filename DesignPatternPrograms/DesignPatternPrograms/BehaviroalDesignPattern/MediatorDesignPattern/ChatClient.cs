// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatClient.cs" company="Bridgelabz">
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
    /// This is Chat client class
    /// </summary>
    public class ChatClient
    {
        /// <summary>
        /// This is Chat Method for Printing Messages
        /// </summary>
        public void Chat()
        {
            ////Object for ChatMediator
            ChatMediator MediatorObj = new ChatMediatorImpl();
            UserMediator user1 = new UserImpl(MediatorObj, "Venu");
            UserMediator user2 = new UserImpl(MediatorObj, "Bandi");
            UserMediator user3 = new UserImpl(MediatorObj, "Raj");
            MediatorObj.AddUser(user1); ////Adding user1
            MediatorObj.AddUser(user2); ////Adding user2
            MediatorObj.AddUser(user3); ////Adding user3
            user1.Send("Hello");
            user2.Receive("Hello");

        }
    }
}
