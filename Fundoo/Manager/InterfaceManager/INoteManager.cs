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
        Task<string> AddNote(Notemodel noteModel);
        /// <summary>
        /// This is Delete Note Task
        /// </summary>
        /// <param name="NoteID"></param>
        /// <returns></returns>
        Task<string> DeleteNote(int NoteID);
        /// <summary>
        /// This is Update Note Task
        /// </summary>
        /// <param name="noteModel"></param>
        /// <returns></returns>
        Task<string> UpdateNote(Notemodel noteModel);
        /// <summary>
        /// This is Get Note Task 
        /// </summary>
        /// <param name="NoteID"></param>
        /// <returns></returns>
        List<Notemodel> GetNote(int NoteID);

    }
}
