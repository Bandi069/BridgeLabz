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
        Task<string> AddNote(Notemodel noteModel);
        /// <summary>
        /// Deletes the note.
        /// </summary>
        /// <param name="NoteID">The note identifier.</param>
        /// <returns></returns>
        Task<int> DeleteNote(int NoteID);
        /// <summary>
        /// Updates the note.
        /// </summary>
        /// <param name="notemodel">The notemodel.</param>
        /// <returns></returns>
        Task<string> UpdateNote(Notemodel notemodel);
        /// <summary>
        /// Gets the note.
        /// </summary>
        /// <param name="NoteID">The note identifier.</param>
        /// <returns></returns>
        List<Notemodel> GetNote(int NoteID);

    }
}
