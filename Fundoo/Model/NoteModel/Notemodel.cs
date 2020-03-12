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
        private string addImg;
        private string remainder;
        private string addColor;
        private string d;
        [Key]
        public string NoteID { get => noteID; set => noteID = value; }
        public string Archive { get => archive; set => archive = value; }
        public string AddImg { get => addImg; set => addImg = value; }
        public string Remainder { get => remainder; set => remainder = value; }
        public string PinNote { get => pinNote; set => pinNote = value; }
    }
}
