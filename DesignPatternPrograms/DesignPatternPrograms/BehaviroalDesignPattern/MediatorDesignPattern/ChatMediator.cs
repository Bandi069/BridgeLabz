// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatMediator.cs" company="Bridgelabz">
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
    /// This is Chat mediator interface
    /// </summary>
    public interface ChatMediator
    {
        /// <summary>
        /// This is for message method 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="user"></param>
        public void Message(string msg, UserMediator user);
        /// <summary>
        /// This is AddUser method  for adding user 
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(UserMediator user);
    }
    
}
