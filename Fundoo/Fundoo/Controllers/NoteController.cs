using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager.InterfaceManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.NoteModel;

namespace Fundoo.Controllers
{
    //[Authorize]
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
        [Route("addnotes")]
        public IActionResult AddNote([FromBody]Notemodel noteModel)
        {
            try
            {
                  var add =  this.noteManager.AddNote(noteModel);
                return this.Ok(add);
            }
            catch (Exception e)
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
        public IActionResult DeleteNote(int Noteid)
        {
            try
            {
                var delete =  this.noteManager.DeleteNote(Noteid);
                return this.Ok(delete);
            }
            catch (Exception e)
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
        public  IActionResult UpdateNote(Notemodel noteModel)
        {
            try
            {
                var update =  this.noteManager.UpdateNote(noteModel);
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
        [Route("displaynote")]
        public List<Notemodel> GetList(int Noteid)
        {
            return this.noteManager.GetNote(Noteid);
        }
        [HttpGet]
        [Route("getnote")]
        public List<Notemodel> Getnote()
        {
            
            return this.noteManager.Getallnote();
        }

        /// <summary>
        /// Trashes the specified noteid.
        /// </summary>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("trash")]
        public async Task<IActionResult> Trash(int noteid)
        {
            try
            {
                var trash = await this.noteManager.Trash(noteid);
                return this.Ok(trash);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Removes the trash.
        /// </summary>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("removetrash")]
        public async Task<IActionResult> RemoveTrash(int noteid)
        {
            try
            {
                var trash = await this.noteManager.RemoveTrash(noteid);
                return this.Ok(trash);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Restores the trash.
        /// </summary>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("restoretrash")]
        public async Task<IActionResult> RestoreTrash(int noteid)
        {
            try
            {
                var trash = await this.noteManager.RestoreTrash(noteid);
                return this.Ok(trash);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Restores all trash.
        /// </summary>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("restorealltrash")]
        public async Task<IActionResult> RestoreAllTrash(int noteid)
        {
            try
            {
                var trash = await this.noteManager.RestoreAllTrash(noteid);
                return this.Ok(trash);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Remainders the specified note identifier.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("reminder")]
        public IActionResult Remainder(int NoteId)
        {
            try
            {
                var remainder = this.noteManager.Remainder(NoteId);
                return Ok(remainder);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Archieves the specified noteid.
        /// </summary>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("archive")]
        public async Task<IActionResult> Archieve(int noteid)
        {
            try
            {
                var archieve = await this.noteManager.Archieve(noteid);
                return this.Ok(archieve);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Uns the archieve.
        /// </summary>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("unarchive")]
        public async Task<IActionResult> UnArchieve(int noteid)
        {
            try
            {
                var unarchieve = await this.noteManager.UnArchieve(noteid);
                return this.Ok(unarchieve);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Gets the archieve list.
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("getarchive")]
        public List<Notemodel> GetArchieveList()
        {
            return this.noteManager.GetArchieveList();
        }

        /// <summary>
        /// Pins the specified noteid.
        /// </summary>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("pin")]
        public async Task<IActionResult> Pin(int noteid)
        {
            try
            {
                var pin = await this.noteManager.Pin(noteid);
                return this.Ok(pin);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("unpin")]
        public async Task<IActionResult> UnPin(int noteid)
        {
            try
            {
                var unpin = await this.noteManager.UnPin(noteid);
                return this.Ok(unpin);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Adds the color.
        /// </summary>
        /// <param name="noteid">The noteid.</param>
        /// <param name="addcolor">The addcolor.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("addcolor")]
        public async Task<IActionResult> AddColor(int noteid, string addcolor)
        {
            try
            {
                var color = await this.noteManager.AddColor(noteid, addcolor);
                return Ok(color);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Uploads the image.
        /// </summary>
        /// <param name="noteid">The noteid.</param>
        /// <param name="img">The img.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("uploadimage")]
        public IActionResult UploadImage(int noteid, IFormFile img)
        {
            try
            {
                var upload = this.noteManager.UploadImage(noteid, img);
                return this.Ok(upload);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}