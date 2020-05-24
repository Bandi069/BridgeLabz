using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.NoteModel
{
    /// <summary>
    /// Note class
    /// </summary>
    public class Notemodel
    {
        /// <summary>
        /// The note identifier
        /// </summary>
        private int noteID;
        /// <summary>
        /// The pin note
        /// </summary>
        private bool pinNote;
        /// <summary>
        /// The archive
        /// </summary>
        private bool archive;
        /// <summary>
        /// The description
        /// </summary>
        private string description;
        /// <summary>
        /// The title
        /// </summary>
        private string title;
        /// <summary>
        /// The add img
        /// </summary>
        private string addImg;
        /// <summary>
        /// The remainder
        /// </summary>
        private string reminder;
        /// <summary>
        /// The add color
        /// </summary>
        private string addColor;
        /// <summary>
        /// The trash/
        /// </summary>
        private bool trash;
        /// <summary>
        /// The emailid
        /// </summary>
        private string email;
        private DateTime? date;
        private DateTime? modifiedDate;

        /// <summary>
        /// Gets or sets the note identifier.
        /// </summary>
        /// <value>
        /// The note identifier.
        /// </value>
        [Key]
        public int NoteID { get => noteID; set => noteID = value; }
       
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get => title; set => title = value; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get => description; set => description = value; }
        
        /// <summary>
        /// Gets or sets the add img.
        /// </summary>
        /// <value>
        /// The add img.
        /// </value>
        public string AddImg { get => addImg; set => addImg = value; }
        
        /// <summary>
        /// Gets or sets the color of the add.
        /// </summary>
        /// <value>
        /// The color of the add.
        /// </value>
        public string AddColor { get => addColor; set => addColor = value; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Notemodel"/> is trash.
        /// </summary>
        /// <value>
        ///   <c>true</c> if trash; otherwise, <c>false</c>.
        /// </value>
        public bool Trash { get => trash; set => trash = value; }
        /// <summary>
        /// Gets or sets a value indicating whether [pin note].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [pin note]; otherwise, <c>false</c>.
        /// </value>
        public bool PinNote { get => pinNote; set => pinNote = value; }
        
        public DateTime? ModifiedTime { get; set; }
        public DateTime? Date { get => date; set => date = value; }
        public bool Archive { get => archive; set => archive = value; }
        public string Email { get => email; set => email = value; }
        public string Reminder { get => reminder; set => reminder = value; }
        public DateTime? ModifiedDate { get => modifiedDate; set => modifiedDate = value; }
    }
}
