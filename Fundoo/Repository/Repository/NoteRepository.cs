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
    /// <summary>
    /// This is Note Repository Class
    /// </summary>
    public class NoteRepository : INoteRepository
    {
        /// <summary>
        /// User Context
        /// </summary>
        private readonly UserContext userContext;

        public NoteRepository()
        {
        }

        /// <summary>
        /// This is OCnstructor Dependency injection
        /// </summary>
        /// <param name="userContext"></param>
        public NoteRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }
        /// <summary>
        /// This is AddNote Task
        /// </summary>
        /// <param name="noteModel"></param>
        /// <returns></returns>
        public async Task<string> AddNote(Notemodel noteModel)
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
                Trash = false
            };
            userContext.Notemodels.Add(notemodel);
            var a = await Task.Run(() => userContext.SaveChanges());
            return null;
        }
        /// <summary>
        /// This is DeleteNode Task
        /// </summary>
        /// <param name="Noteid"></param>
        /// <returns></returns>
        public async Task<int> DeleteNote(int Noteid)
        {
            var deletenote = userContext.Notemodels.Where(del => del.NoteID == Noteid).SingleOrDefault();
            if (deletenote != null)
            {
                userContext.Notemodels.Remove(deletenote);
                await Task.Run(() => userContext.SaveChanges());
            }
            return default;
        }
        /// <summary>
        /// This is Get List node Task 
        /// </summary>
        /// <param name="NoteID"></param>
        /// <returns></returns>
        public  List<Notemodel> GetNote(int NoteID)
        {
            var listNote = userContext.Notemodels.Where(list => list.NoteID == NoteID).SingleOrDefault();
            if (listNote != null)
            {
                return userContext.Notemodels.Where(list => list.NoteID == NoteID).ToList();
            }
            return null;
        }
        /// <summary>
        /// This is  Update Note Task
        /// </summary>
        /// <param name="notemodel"></param>
        /// <returns></returns>
        public async Task<string> UpdateNote(Notemodel notemodel)
        {
            var updatenote = userContext.Notemodels.Where(up => up.NoteID == notemodel.NoteID).SingleOrDefault();
            if (updatenote != null)
            {
                updatenote.Emailid = notemodel.Emailid;
                updatenote.Description = notemodel.Description;
                updatenote.Title = notemodel.Title;
                updatenote.CreateTime = notemodel.CreateTime;
                updatenote.ModifiedTime = notemodel.ModifiedTime;
                this.userContext.Notemodels.Update(notemodel);
            }
            await Task.Run(() => userContext.SaveChanges());
            return null;
        }

    }
}
