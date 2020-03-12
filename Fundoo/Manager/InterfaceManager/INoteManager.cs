using Model.NoteModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.InterfaceManager
{
    public interface INoteManager
    {
        Task<string> AddNote(Notemodel noteModel);
        Task<string> DeleteNote(int NoteID);
        Task<string> UpdateNote(Notemodel noteModel);
        Task<string> getNote(int NoteID);

    }
}
