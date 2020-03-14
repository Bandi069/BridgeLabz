using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        private string emailid;
        /// <summary>
        /// The label
        /// </summary>
        private string label;
        /// <summary>
        /// Gets or sets the label identifier.
        /// </summary>
        /// <value>
        /// The label identifier.
        /// </value>
        public int LabelID { get => labelID; set => labelID = value; }
        /// <summary>
        /// Gets or sets the emailid.
        /// </summary>
        /// <value>
        /// The emailid.
        /// </value>
        [Key]
        public string Emailid { get => emailid; set => emailid = value; }
        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public string Label { get => label; set => label = value; }
    }
}
