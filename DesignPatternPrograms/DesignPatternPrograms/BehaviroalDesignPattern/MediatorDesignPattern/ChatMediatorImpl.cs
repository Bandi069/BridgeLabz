using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviroalDesignPattern.MediatorDesignPattern
{
    public class ChatMediatorImpl : ChatMediator
    {
        
        private List<UserMediator> users;
        public ChatMediatorImpl()
        {
            this.users = new Array();

        }

        public void AddUser(UserMediator user)
        {
            this.users.Add(user);
        }

        public void Message(string msg, UserMediator user)
        {
            foreach (UserMediator userin in this.users)
            {

                if (userin != user)
                {
                    userin.receive(msg);
                }

            }   }
    }
}
