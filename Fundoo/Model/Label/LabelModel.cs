using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace Model.Label
{
    /// <summary>
    /// This is Label Model
    /// </summary>
    public class LabelModel
    {
        /// <summary>
        /// The label identifier
        /// </summary>
        private int labelID;
        /// <summary>
        /// The emailid
        /// </summary>
        private string email;
        /// <summary>
        /// The label
        /// </summary>
        private string label;
        private int noteId;
        /// <summary>
        /// Gets or sets the label identifier.
        /// </summary>
        /// <value>
        /// The label identifier.
        /// </value>
         [Key]
        public int LabelID { get => labelID; set => labelID = value; }
        /// <summary>
        /// Gets or sets the emailid.
        /// </summary>
        /// <value>
        /// The emailid.
        /// </value>
        [ForeignKey("RegistrationModel")]
        public string Email { get => email; set => email = value; }
        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public string Label { get => label; set => label = value; }
        public int NoteId { get => noteId; set => noteId = value; }
    }
}
