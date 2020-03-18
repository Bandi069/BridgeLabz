using Model.Label;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.InterfaceManager
{
    /// <summary>
    /// Ilabel manager interface
    /// </summary>
    public interface ILabelManager
    {
        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="labelModle">The label modle.</param>
        /// <returns></returns>
        string AddLabel(LabelModel labelModle);
        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="LabelID">The label identifier.</param>
        /// <returns></returns>
        string DeleteLabel(int LabelID);
        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        string UpdateLabel(LabelModel labelModel);
        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="LabelID">The label identifier.</param>
        /// <returns></returns>
        List<LabelModel> GetLabel(int LabelID);
    }
}
