using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Label
{
    public class LabelModel
    {
        private int labelID;
        private string emailid;
        private string label;
       
        public int LabelID { get => labelID; set => labelID = value; }
       [Key]
        public string Emailid { get => emailid; set => emailid = value; }
        public string Label { get => label; set => label = value; }
    }
}
