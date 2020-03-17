using Experimental.System.Messaging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Utility
{
    public class QueueChecking
    {
        static void Main(string[] args)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                MessageQueue msgqueue = new MessageQueue();
                Message[] Messages = null;
                MessageQueue[] QueueList = MessageQueue.GetPrivateQueuesByMachine(".");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("bandivenu89@gmail.com");
                mail.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = new NetworkCredential("bandivenu89@gmail.com", "sanVedha2212")
                };
                try
                {
                    foreach (MessageQueue queue in QueueList)
                    {
                        Messages = queue.GetAllMessages();
                        if (Messages.Length > 0)
                        {
                            foreach (Message ma in Messages)
                            {
                                ma.Formatter = new XmlMessageFormatter(new String[] { "System.String,mscorlib" });
                                string message = ma.Body.ToString();
                                mail.To.Add("venubandi89@gmail.com");
                                mail.Body = message;
                                smtp.Send(mail);
                                queue.Receive();
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                   msgqueue.Dispose();
                }
            }
        }
    }
}
