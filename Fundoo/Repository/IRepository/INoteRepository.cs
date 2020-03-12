using Model.NoteModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface INoteRepository
    {
        Task AddNote(Notemodel noteModel);
        Task DeleteNote(int NoteID);
        Task UpdateNote(Notemodel notemodel);
        List<Notemodel> GetNote(int NoteID);

    }
}
