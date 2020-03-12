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
            Notemodel notemodel = new Notemodel()
            {
                Emailid = noteModel.Emailid,
                Title = noteModel.Title,
                Description = noteModel.Description,
                CreateTime = noteModel.CreateTime,
                ModifiedTime = noteModel.ModifiedTime,
                AddImg = null,
                AddColor = null,
                PinNote = false,
                Remainder = null, 
                Archive = null,
                Trash=false
            };
            userContext.Notemodels.Add(notemodel);
            return Task.Run(() => userContext.SaveChanges());
        }

        public Task DeleteNote(int NoteID)
        {
            return null;
        }

        public List<Notemodel> GetNote(int NoteID)
        {
            return null;
        }

        public Task UpdateNote(Notemodel notemodel)
        {
            return null;
        }
    }
}
