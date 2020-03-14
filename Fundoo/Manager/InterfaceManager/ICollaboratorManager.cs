using Model.Collaborator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.InterfaceManager
{
   public interface ICollaboratorManager
    {
        Task AddCollaborator(ModelCollaborator modelCollaborator);
        Task DeleteCollaborator(ModelCollaborator modelCollaborator);
    }
}
