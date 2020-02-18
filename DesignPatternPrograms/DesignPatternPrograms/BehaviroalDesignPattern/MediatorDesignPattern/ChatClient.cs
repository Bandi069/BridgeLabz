using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviroalDesignPattern.MediatorDesignPattern
{
    class ChatClient
    {
        public void Chat()
        {
            ChatMediator MediatorObj = new ChatMediatorImpl();
            UserMediator user1 = new UserImpl(MediatorObj, "Venu");
            UserMediator user2 = new UserImpl(MediatorObj, "Bandi");
            UserMediator user3 = new UserImpl(MediatorObj, "Raj");
            MediatorObj.AddUser(user1);
            MediatorObj.AddUser(user2);
            MediatorObj.AddUser(user3);
            user1.Send("Hello");
            user2.Receive("Hello");

        }
    }
}
