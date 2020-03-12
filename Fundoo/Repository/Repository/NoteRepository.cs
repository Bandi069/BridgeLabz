using Model.NoteModel;
using Repository.IRepository;
using Repository.UserDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Task DeleteNote(int Noteid)
        {
            var deletenote = userContext.Notemodels.Where(del => del.NoteID == Noteid).SingleOrDefault();
            if(deletenote!=null)
            {
                userContext.Notemodels.Remove(deletenote);
                return Task.Run(() => userContext.SaveChanges());
            }
            return null;
        }

        public List<Notemodel> GetNote(int NoteID)
        {

            return null;
        }

        public Task UpdateNote(Notemodel notemodel)
        {
            var updatenote = userContext.Notemodels.Where(up => up.NoteID == notemodel.NoteID).SingleOrDefault();
            if(updatenote!=null)
            {
                updatenote.Emailid = notemodel.Emailid;
                updatenote.Description = notemodel.Description;
                updatenote.Title= notemodel.Title;
                updatenote.CreateTime= notemodel.CreateTime;
                updatenote.ModifiedTime= notemodel.ModifiedTime;
            }
            return null;
        }
    }
}
