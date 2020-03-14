using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Collaborator
{
    /// <summary>
    /// This is Model Collaborator Class
    /// </summary>
    public class ModelCollaborator 
    {
        /// <summary>
        /// The note identifier
        /// </summary>
        private int noteID;
        /// <summary>
        /// The sender mail
        /// </summary>
        private string senderMail;
        /// <summary>
        /// The receiver mail
        /// </summary>
        private string receiverMail;
        /// <summary>
        /// Gets or sets the note identifier.
        /// </summary>
        /// <value>
        /// The note identifier.
        /// </value>
        public int NoteID { get => noteID; set => noteID = value; }
        /// <summary>
        /// Gets or sets the sender mail.
        /// </summary>
        /// <value>
        /// The sender mail.
        /// </value>
        public string SenderMail { get => senderMail; set => senderMail = value; }
        /// <summary>
        /// Gets or sets the receiver mail.
        /// </summary>
        /// <value>
        /// The receiver mail.
        /// </value>
        public string ReceiverMail { get => receiverMail; set => receiverMail = value; }
    }
}
