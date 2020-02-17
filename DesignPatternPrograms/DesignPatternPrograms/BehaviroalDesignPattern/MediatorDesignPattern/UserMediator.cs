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
    public class UserMediator
    {
        private ChatMediator mediator;
        private string Name;
		public UserMediator(ChatMediator med, String name)
		{
			this.mediator = med;
			this.Name = name;
		}

		public void Send(String msg);

		public  void receive(String msg);
	}
}
