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
            UserMediator user1 = new UserImpl(MediatorObj, "Pankaj");
            UserMediator user2 = new UserImpl(MediatorObj, "Lisa");
            UserMediator user3 = new UserImpl(MediatorObj, "Saurabh");

        }
    }
}
