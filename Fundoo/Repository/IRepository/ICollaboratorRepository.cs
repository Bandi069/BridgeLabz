using Model.Collaborator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.CollaboratorRepository
{
    /// <summary>
    /// This is Interface Collaborator Class
    /// </summary>
    public interface ICollaboratorRepository
    {
        /// <summary>
        /// This is AddCollaborator Task
        /// </summary>
        /// <param name="modelCollaborator"></param>
        /// <returns></returns>
        Task AddCollaborator(ModelCollaborator modelCollaborator);
        /// <summary>
        /// This is Delete Collaborator Task
        /// </summary>
        /// <param name="modelCollaborator"></param>
        /// <returns></returns>
        Task DeleteCollaborator(ModelCollaborator modelCollaborator);
        /// <summary>
        /// This is Update Collabarator 
        /// </summary>
        /// <param name="modelCollaborator"></param>
        /// <returns></returns>
        Task UpdateCollaborator(ModelCollaborator modelCollaborator);
       
    }
}
