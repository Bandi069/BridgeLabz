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
    public interface ChatMediator
    {
        public void Message(string msg, UserMediator user);
        public void AddUser(UserMediator user);
    }
    
}
