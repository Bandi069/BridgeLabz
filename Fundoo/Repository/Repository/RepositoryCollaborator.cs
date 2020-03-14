using Model.Collaborator;
using Repository.UserDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.CollaboratorRepository
{
    /// <summary>
    /// This is Repository Collaborator Class
    /// </summary>
    public class RepositoryCollaborator : ICollaboratorRepository
    {
        /// <summary>
        /// This is UserContext
        /// </summary>
        private readonly UserContext userContext;
        /// <summary>
        /// Constructor Depended=ncy injection
        /// </summary>
        /// <param name="userContext"></param>
        public RepositoryCollaborator(UserContext userContext)
        {
            this.userContext = userContext;
        }
        /// <summary>
        /// Add collaborator Task
        /// </summary>
        /// <param name="modelCollaborator"></param>
        /// <returns></returns>
        public Task AddCollaborator(ModelCollaborator modelCollaborator)
        {
            try
            {
                var add = this.userContext.Notemodels.Where(ad => ad.NoteID == modelCollaborator.NoteID && ad.Emailid == modelCollaborator.SenderMail).SingleOrDefault();
                if (add != null)
                {
                    var adduser = this.userContext.Register.Where(ad => ad.Emailid == modelCollaborator.ReceiverMail).SingleOrDefault();
                    {
                        var collaborate = new ModelCollaborator()
                        {
                            NoteID = modelCollaborator.NoteID,
                            SenderMail = modelCollaborator.SenderMail,
                            ReceiverMail = modelCollaborator.ReceiverMail
                        };
                        userContext.Add(modelCollaborator);
                        userContext.SaveChanges();
                    }
                }
                return Task.Run(() => userContext.SaveChanges());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// delete Collaborator Task
        /// </summary>
        /// <param name="modelCollaborator"></param>
        /// <returns></returns>
        public Task DeleteCollaborator(ModelCollaborator modelCollaborator)
        {
            try
            {
                var delete = this.userContext.Notemodels.Where(del => del.NoteID == modelCollaborator.NoteID).SingleOrDefault();
                this.userContext.Notemodels.Remove(delete);
                return Task.Run(() => userContext.SaveChanges());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// This is UpdateCollaborator Task
        /// </summary>
        /// <param name="modelCollaborator"></param>
        /// <returns></returns>
        public Task UpdateCollaborator(ModelCollaborator modelCollaborator)
        {
            try
            {
                var Update = this.userContext.Notemodels.Where(up => up.NoteID == modelCollaborator.NoteID && up.Emailid == modelCollaborator.SenderMail).SingleOrDefault();
                if (Update != null)
                {
                    var updateuser = this.userContext.Register.Where(ad => ad.Emailid == modelCollaborator.ReceiverMail).SingleOrDefault();
                    {
                        var collaborate = new ModelCollaborator()
                        {
                            NoteID = modelCollaborator.NoteID,
                            SenderMail = modelCollaborator.SenderMail,
                            ReceiverMail = modelCollaborator.ReceiverMail
                        };
                        userContext.Add(modelCollaborator);
                        userContext.SaveChanges();
                    }
                }
                return Task.Run(() => userContext.SaveChanges());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
