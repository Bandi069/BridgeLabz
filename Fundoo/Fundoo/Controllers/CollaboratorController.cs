using Manager.InterfaceManager;
using Microsoft.AspNetCore.Mvc;
using Model.Collaborator;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundoo.Controllers
{
    //[Authenticate]
    /// <summary>
    /// This is Collabarator Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Authorize]
    public class CollaboratorController : ControllerBase
    {
        /// <summary>
        /// The collaborator manager
        /// </summary>
        private readonly ICollaboratorManager collaboratorManager;
        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorController"/> class.
        /// </summary>
        /// <param name="collaboratorManager">The collaborator manager.</param>
        public CollaboratorController(ICollaboratorManager collaboratorManager)
        {
            this.collaboratorManager = collaboratorManager;
        }
        /// <summary>
        /// Adds the collaborator.
        /// </summary>
        /// <param name="modelCollaborator">The model collaborator.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("addcollaborator")]
        public  IActionResult AddCollaborator([FromBody]ModelCollaborator modelCollaborator)
        {
            try
            {
                var add =  this.collaboratorManager.AddCollaborator(modelCollaborator);
                return Ok(new { add });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Deletes the collaborator.
        /// </summary>
        /// <param name="modelCollaborator">The model collaborator.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("deletecollaborator")]
        public  IActionResult DeleteCollaborator(int id)
        {
            try
            {
                var Delete =  this.collaboratorManager.DeleteCollaborator(id);
                return Ok(new { Delete });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}
