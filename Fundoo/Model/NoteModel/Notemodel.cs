using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.NoteModel
{
    public class Notemodel
    {
        private string noteID;
        private string pinNote;
        private string archive;
        private string description;
        private string title;
        private string addImg;
        private string remainder;
        private string addColor;
        private string trash;
        private string emailid;
        [Key]
        public string NoteID { get => noteID; set => noteID = value; }
        public string Archive { get => archive; set => archive = value; }
        public string AddImg { get => addImg; set => addImg = value; }
        public string Remainder { get => remainder; set => remainder = value; }
        public string PinNote { get => pinNote; set => pinNote = value; }
        public string AddColor { get => addColor; set => addColor = value; }
        public string Trash { get => trash; set => trash = value; }
        public string Emailid { get => emailid; set => emailid = value; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
    }
}
