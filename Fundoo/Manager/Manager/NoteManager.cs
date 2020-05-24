using Manager.InterfaceManager;
using Microsoft.AspNetCore.Http;
using Model.NoteModel;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    /// <summary>
    /// This is Note Manager Class
    /// </summary>
    public class NoteManager : INoteManager
    {
        /// <summary>
        /// This is INoteRepository  
        /// </summary>
        private readonly INoteRepository noteRepository;
        /// <summary>
        /// constructor of notemanager dependency injection
        /// </summary>
        /// <param name="noteRepository"></param>
        public NoteManager(INoteRepository noteRepository)
        {
            this.noteRepository = noteRepository;
        }
        /// <summary>
        /// Async AdddNote Task
        /// </summary>
        /// <param name="noteModel"></param>
        /// <returns></returns>
        public  string AddNote(Notemodel noteModel)
        {
            try
            {
                 this.noteRepository.AddNote(noteModel);
                return "Note Added";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Delete noteAsyn task
        /// </summary>
        /// <param name="NoteID"></param>
        /// <returns></returns>
        public  string DeleteNote(int NoteID)
        {
            try
            {
                 this.noteRepository.DeleteNote(NoteID);
                return "Note Deleted";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// THis is to get note by NoteID
        /// </summary>
        /// <param name="NoteID"></param>
        /// <returns></returns>
        public List<Notemodel> GetNote(int NoteID)
        {
            try
            {
                var notelist = new List<Notemodel>();
                var getlist = this.noteRepository.GetNote(NoteID);
                foreach (var nlist in getlist)
                {
                    notelist.Add(nlist);
                }
                return notelist;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// This is asynchronous Update Note Task
        /// </summary>
        /// <param name="noteModel"></param>
        /// <returns></returns>
        public string UpdateNote(Notemodel noteModel)
        {
            try
            {
                 this.noteRepository.UpdateNote(noteModel);
                return "Note Updated";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Trashes the specified noteid.
        /// </summary>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> Trash(int noteid)
        {
            try
            {
                await this.noteRepository.Trash(noteid);
                return "Moved to Trash";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Gets the trash.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Notemodel> GetTrash()
        {
            try
            {
                var trash = new List<Notemodel>();
                var Trashlist = this.noteRepository.GetTrash();
                foreach (var list in Trashlist)
                {
                    trash.Add(list);
                }
                return trash;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Removes the trash.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> RemoveTrash(int NoteId)
        {
            try
            {
                await this.noteRepository.RemoveTrash(NoteId);
                return "Trash Removed";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Restores the trash.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> RestoreTrash(int NoteId)
        {
            try
            {
                await this.noteRepository.RestoreTrash(NoteId);
                return "Trash Restored";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Restores all trash.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> RestoreAllTrash(int NoteId)
        {
            try
            {
                await this.noteRepository.RestoreAllTrash(NoteId);
                return "Trash Restored";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Remainders the specified note identifier.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string Remainder(int NoteId)
        {
            try
            {
                this.noteRepository.Remainder(NoteId);
                return "Remainder Successfull";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int DeleteRemainder(int id)
        {
            try
            {
                return this.noteRepository.DeleteReminder(id);

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        /// <summary>
        /// Archieves the specified note identifier.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> Archieve(int NoteId)
        {
            try
            {
                await this.noteRepository.Archieve(NoteId);
                return "Archeied Success";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Uns the archieve.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> UnArchieve(int NoteId)
        {
            try
            {
                await this.noteRepository.UnArchieve(NoteId);
                return "UnArcheied Success";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Gets the archieve list.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Notemodel> GetArchieveList()
        {
            try
            {
                var getarch = new List<Notemodel>();
                var acrh = this.noteRepository.GetTrash();
                foreach (var list in getarch)
                {
                    getarch.Add(list);
                }
                return getarch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Pins the specified noteid.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> Pin(int Noteid)
        {
            try
            {
                await this.noteRepository.Pin(Noteid);
                return "Pinned";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> UnPin(int Noteid)
        {
            try
            {
                await this.noteRepository.UnPin(Noteid);
                return "Unpinned";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Adds the color.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <param name="addcolor">The addcolor.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> AddColor(int Noteid, string addcolor)
        {
            try
            {
                await this.noteRepository.AddColor(Noteid, addcolor);
                return "Color Added";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Uploads the image.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <param name="img">The img.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string UploadImage(int Noteid, IFormFile img)
        {
            try
            {
                this.noteRepository.UploadImage(Noteid, img);
                return "Image Uploaded";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Notemodel> Getallnote()
        {
            return this.noteRepository.Getallnote();
        }
    }
}
