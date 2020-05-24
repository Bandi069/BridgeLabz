using Microsoft.AspNetCore.Http;
using Model.NoteModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    /// <summary>
    /// This is Inoterepositoy Interface
    /// </summary>
    public interface INoteRepository
    {
        /// <summary>
        /// Adds the note.
        /// </summary>
        /// <param name="noteModel">The note model.</param>
        /// <returns></returns>
        string AddNote(Notemodel noteModel);
        /// <summary>
        /// Deletes the note.
        /// </summary>
        /// <param name="NoteID">The note identifier.</param>
        /// <returns></returns>
        string DeleteNote(int NoteID);
        /// <summary>
        /// Updates the note.
        /// </summary>
        /// <param name="notemodel">The notemodel.</param>
        /// <returns></returns>
        string UpdateNote(Notemodel notemodel);
        /// <summary>
        /// Gets the note.
        /// </summary>
        /// <param name="NoteID">The note identifier.</param>
        /// <returns></returns>
        List<Notemodel> GetNote(int NoteID);
        List<Notemodel> Getallnote();
        /// <summary>
        /// Trashes the specified noteid.
        /// </summary>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        Task Trash(int noteid);
        /// <summary>
        /// Gets the trash.
        /// </summary>
        /// <returns></returns>
        List<Notemodel> GetTrash();
        /// <summary>
        /// Removes the trash.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        Task RemoveTrash(int NoteId);
        /// <summary>
        /// Restores the trash.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        Task RestoreTrash(int NoteId);
        /// <summary>
        /// Restores all trash.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        Task RestoreAllTrash(int NoteId);
        /// <summary>
        /// Remainders the specified note identifier.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        int Remainder(int NoteId);
        int DeleteReminder(int id);
        /// <summary>
        /// Archieves the specified note identifier.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        Task Archieve(int NoteId);
        /// <summary>
        /// Uns the archieve.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        Task UnArchieve(int NoteId);
        /// <summary>
        /// Gets the archieve list.
        /// </summary>
        /// <returns></returns>
        List<Notemodel> GetArchieveList();
        /// <summary>
        /// Pins the specified noteid.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <returns></returns>
        Task Pin(int Noteid);
        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <returns></returns>
        Task UnPin(int Noteid);
        /// <summary>
        /// Adds the color.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <param name="addcolor">The addcolor.</param>
        /// <returns></returns>
        Task AddColor(int Noteid, string addcolor);
        /// <summary>
        /// Uploads the image.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <param name="img">The img.</param>
        /// <returns></returns>
        string UploadImage(int Noteid, IFormFile img);

    }
}
