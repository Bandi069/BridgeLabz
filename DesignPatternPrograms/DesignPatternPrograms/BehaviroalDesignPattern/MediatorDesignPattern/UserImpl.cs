using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviroalDesignPattern.MediatorDesignPattern
{
    public class UserImpl : UserMediator
    {
        public string name;

        public UserImpl(ChatMediator msg, string name) : base(msg, name) { }
       public void send(string msg)
        {
            Console.WriteLine(this.name +"Messge sending "+msg);
        }
        public void receive(string msg)
        {
            Console.WriteLine(this.name + "Recieve messgae :" + msg);
        }
    }
}
