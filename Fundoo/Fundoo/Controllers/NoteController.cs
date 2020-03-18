using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager.InterfaceManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.NoteModel;

namespace Fundoo.Controllers
{
    /// <summary>
    /// Note Controller Class
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public class NoteController : ControllerBase
    {
        /// <summary>
        /// The note manager
        /// </summary>
        private readonly INoteManager noteManager;
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteController"/> class.
        /// </summary>
        /// <param name="noteManager">The note manager.</param>
        public NoteController(INoteManager noteManager)
        {
            this.noteManager = noteManager;
        }

        /// <summary>
        /// Adds the note.
        /// </summary>
        /// <param name="noteModel">The note model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("addnote")]
        public async Task<IActionResult> AddNote(Notemodel noteModel)
        {
            try
            {
                var add = await this.noteManager.AddNote(noteModel);
                return this.Ok(add);
            }
            catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        
        /// <summary>
        /// Deletes the note.
        /// </summary>
        /// <param name="noteModel">The note model.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("deletenote")]
        public async Task<IActionResult> DeleteNote(int Noteid)
        {
            try
            {
                var delete = await this.noteManager.DeleteNote(Noteid);
                return this.Ok(delete);
            }
            catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Updates the note.
        /// </summary>
        /// <param name="noteModel">The note model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("updatenote")]
        public async Task<IActionResult> UpdateNote(Notemodel noteModel)
        {
            try
            {
                var update = await this.noteManager.UpdateNote(noteModel);
                return this.Ok(update);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("show")]
        public List<Notemodel> GetList(int Noteid)
        {
            return this.noteManager.GetNote(Noteid);
        }
    }
}