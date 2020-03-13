using Model.NoteModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface INoteRepository
    {
        Task<string> AddNote(Notemodel noteModel);
        Task<int> DeleteNote(int NoteID);
        Task<string> UpdateNote(Notemodel notemodel);
        List<Notemodel> GetNote(int NoteID);

    }
}
