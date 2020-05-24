using Manager.InterfaceManager;
using Model.Collaborator;
using Repository.CollaboratorRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    /// <summary>
    /// Collaborator Manager class
    /// </summary>
    /// <seealso cref="Manager.InterfaceManager.ICollaboratorManager" />
    public class CollaboratorManager : ICollaboratorManager
    {
        /// <summary>
        /// The collaborator repository
        /// </summary>
        private readonly ICollaboratorRepository collaboratorRepository;
        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorManager"/> class.
        /// </summary>
        /// <param name="collaboratorRepository">The collaborator repository.</param>
        public CollaboratorManager(ICollaboratorRepository collaboratorRepository)
        {
            this.collaboratorRepository = collaboratorRepository;
        }
        /// <summary>
        /// Adds the collaborator.
        /// </summary>
        /// <param name="modelCollaborator">The model collaborator.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public  string AddCollaborator(ModelCollaborator modelCollaborator)
        {
            try
            {
               return  this.collaboratorRepository.AddCollaborator(modelCollaborator);
                 
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        /// <summary>
        /// Deletes the collaborator.
        /// </summary>
        /// <param name="modelCollaborator">The model collaborator.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string DeleteCollaborator(int noteid)
        {
            try
            {
                return this.collaboratorRepository.DeleteCollaborator(noteid);
                 
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
