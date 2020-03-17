using Experimental.System.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    public class Msmq
    {
        public void MSMQStore(string label, string subject, string body)
        {
            MessageQueue Queue = null;
            try
            {
                if (MessageQueue.Exists(@".\Private$\" + label))
                {
                    Queue = new MessageQueue(@".\Private$\" + label);
                }
                else
                {
                    Queue = MessageQueue.Create(@".\Private$\" + label);
                }
                Queue.Label = label;
                Queue.Send("Subject : " + subject + "\n Body : " + body, "IDG");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
    }
}
