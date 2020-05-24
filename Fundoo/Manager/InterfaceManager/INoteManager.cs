using Microsoft.AspNetCore.Http;
using Model.NoteModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.InterfaceManager
{
    /// <summary>
    /// INote Manager Interface
    /// </summary>
    public interface INoteManager
    {
        /// <summary>
        /// This is Add Note Task
        /// </summary>
        /// <param name="noteModel"></param>
        /// <returns></returns>
        string AddNote(Notemodel noteModel);
        /// <summary>
        /// This is Delete Note Task
        /// </summary>
        /// <param name="NoteID"></param>
        /// <returns></returns>
        string DeleteNote(int NoteID);
        List<Notemodel> Getallnote();
        /// <summary>
        /// This is Update Note Task
        /// </summary>
        /// <param name="noteModel"></param>
        /// <returns></returns>
        string UpdateNote(Notemodel noteModel);
        /// <summary>
        /// This is Get Note Task 
        /// </summary>
        /// <param name="NoteID"></param>
        /// <returns></returns>
        List<Notemodel> GetNote(int NoteID);
        /// <summary>
        /// Trashes the specified noteid.
        /// </summary>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        Task<string> Trash(int noteid);
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
        Task<string> RemoveTrash(int NoteId);
        /// <summary>
        /// Restores the trash.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        Task<string> RestoreTrash(int NoteId);
        /// <summary>
        /// Restores all trash.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        Task<string> RestoreAllTrash(int NoteId);
        /// <summary>
        /// Remainders the specified note identifier.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        string Remainder(int NoteId);
        int DeleteRemainder(int id);
        /// <summary>
        /// Archieves the specified note identifier.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        Task<string> Archieve(int NoteId);
        /// <summary>
        /// Uns the archieve.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        Task<string> UnArchieve(int NoteId);
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
        Task<string> Pin(int Noteid);
        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <returns></returns>
        Task<string> UnPin(int Noteid);
        /// <summary>
        /// Adds the color.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <param name="addcolor">The addcolor.</param>
        /// <returns></returns>
        Task<string> AddColor(int Noteid, string addcolor);
        /// <summary>
        /// Uploads the image.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <param name="img">The img.</param>
        /// <returns></returns>
        string UploadImage(int Noteid, IFormFile img);
    }
}
