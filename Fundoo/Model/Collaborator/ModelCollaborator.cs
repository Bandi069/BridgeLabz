using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Collaborator
{
   public class ModelCollaborator 
    {
        private int noteID;
        private string senderMail;
        private string receiverMail;

        public int NoteID { get => noteID; set => noteID = value; }
        public string SenderMail { get => senderMail; set => senderMail = value; }
        public string ReceiverMail { get => receiverMail; set => receiverMail = value; }
    }
}
