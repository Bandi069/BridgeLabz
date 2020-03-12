using Manager.InterfaceManager;
using Model.NoteModel;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    public class NoteManager : INoteManager
    {
        private readonly INoteRepository noteRepository;
        public NoteManager(INoteRepository noteRepository)
        {
            this.noteRepository = noteRepository;
        }
        public async Task<string> AddNote(Notemodel noteModel)
        {
            try
            {
                 await this.noteRepository.AddNote(noteModel);
                return "Note Added";
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

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

        public List<Notemodel> GetNote(int NoteID)
        {
            try
            {
                var notelist = new List<Notemodel>();
                var getlist = this.noteRepository.GetNote(NoteID);
              foreach(var nlist in getlist)
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
