using Model.NoteModel;
using Repository.IRepository;
using Repository.UserDbContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class NoteRepository : INoteRepository
    {
        private readonly UserContext userContext;
        public NoteRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }
        public Task AddNote(Notemodel noteModel)
        {
            return null;
        }

        public Task DeleteNote(int NoteID)
        {
            throw new NotImplementedException();
        }

        public List<Notemodel> GetNote(int NoteID)
        {
            throw new NotImplementedException();
        }

        public Task UpdateNote(Notemodel notemodel)
        {
            throw new NotImplementedException();
        }
    }
}
