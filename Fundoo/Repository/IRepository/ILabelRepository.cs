using Model.Label;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    /// <summary>
    /// This is ILabel Repository
    /// </summary>
    public interface ILabelRepository
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
        string UpdateLabel(int LabelID,string name);
        /// <summary>
        /// Gets the label models.
        /// </summary>
        /// <param name="LabelID">The label identifier.</param>
        /// <returns></returns>
        List<LabelModel> GetLabelModels(int LabelID);
        
        Task<List<LabelModel>> GetAllLabels();
    }
}
