﻿using System;
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
        private string remainder;
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
        private string emailid;
        /// <summary>
        /// Gets or sets the note identifier.
        /// </summary>
        /// <value>
        /// The note identifier.
        /// </value>
        [Key]
        public int NoteID { get => noteID; set => noteID = value; }
        /// <summary>
        /// Gets or sets the emailid.
        /// </summary>
        /// <value>
        /// The emailid.
        /// </value>
        public string Emailid { get => emailid; set => emailid = value; }
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
        /// Gets or sets the archive.
        /// </summary>
        /// <value>
        /// The archive.
        /// </value>
        public bool Archive { get; set; }
        /// <summary>
        /// Gets or sets the add img.
        /// </summary>
        /// <value>
        /// The add img.
        /// </value>
        public string AddImg { get => addImg; set => addImg = value; }
        /// <summary>
        /// Gets or sets the remainder.
        /// </summary>
        /// <value>
        /// The remainder.
        /// </value>
        public string Remainder { get => remainder; set => remainder = value; }
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

        /// <summary>
        /// Gets or sets the create time.
        /// </summary>
        /// <value>
        /// The create time.
        /// </value>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// Gets or sets the modified time.
        /// </summary>
        /// <value>
        /// The modified time.
        /// </value>
        public DateTime? ModifiedTime { get; set; }

    }
}
