using Manager.InterfaceManager;
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
        public async Task<string> AddNote(Notemodel noteModel)
        {
            try
            {
                await this.noteRepository.AddNote(noteModel);
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
        public async Task<string> DeleteNote(int NoteID)
        {
            try
            {
                await this.noteRepository.DeleteNote(NoteID);
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
        public async Task<string> UpdateNote(Notemodel noteModel)
        {
            try
            {
                await this.noteRepository.UpdateNote(noteModel);
                return "Note Updated";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
