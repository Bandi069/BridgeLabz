using Model.Collaborator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.InterfaceManager
{
    /// <summary>
    /// Icollaborator staff
    /// </summary>
    public interface ICollaboratorManager
    {
        /// <summary>
        /// Adds the collaborator.
        /// </summary>
        /// <param name="modelCollaborator">The model collaborator.</param>
        /// <returns></returns>
        Task<string> AddCollaborator(ModelCollaborator modelCollaborator);
        /// <summary>
        /// Deletes the collaborator.
        /// </summary>
        /// <param name="modelCollaborator">The model collaborator.</param>
        /// <returns></returns>
        Task<string> DeleteCollaborator(ModelCollaborator modelCollaborator);
    }
}
