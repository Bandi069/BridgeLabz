
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Model.NoteModel;
using Repository.IRepository;
using Repository.UserDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
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
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteRepository"/> class.
        /// </summary>
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
        public string AddNote(Notemodel noteModel)
        {
            Notemodel notemodel = new Notemodel()
            {
                Email = noteModel.Email,
                Title = noteModel.Title,
                Description = noteModel.Description,
                Date = noteModel.Date,
                ModifiedTime = noteModel.ModifiedTime,
                AddImg = noteModel.AddImg,
                AddColor = noteModel.AddColor,
                PinNote = noteModel.PinNote,
                Reminder = noteModel.Reminder,
                Archive = noteModel.Archive,
                Trash = noteModel.Trash
            };
            //if (noteModel.Title != " " || noteModel.Description != " ")
            //{

                userContext.Notemodels.Add(notemodel);
                this.userContext.SaveChanges();
                return "New Note Added";
           // }
           // else { return null; }

        }

        /// <summary>
        /// This is DeleteNode Task
        /// </summary>
        /// <param name="Noteid"></param>
        /// <returns></returns>
        public string DeleteNote(int Noteid)
        {
            var deletenote = userContext.Notemodels.Where(del => del.NoteID == Noteid).SingleOrDefault();
            if (deletenote != null)
            {
                userContext.Notemodels.Remove(deletenote);
                Task.Run(() => userContext.SaveChanges());
                return "Note Deleted Successfully";
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// This is Get List node Task 
        /// </summary>
        /// <param name="NoteID"></param>
        /// <returns ></returns>
        public List<Notemodel> GetNote(int NoteID)
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
        public string UpdateNote(Notemodel notemodel)
        {
            var updatenote = userContext.Notemodels.Where(up => up.NoteID == notemodel.NoteID).SingleOrDefault();
            if (updatenote != null)
            {
                updatenote.Email = notemodel.Email;
                updatenote.Description = notemodel.Description;
                updatenote.Title = notemodel.Title;
                updatenote.Date = notemodel.Date;
                updatenote.ModifiedTime = notemodel.ModifiedTime;
                this.userContext.Notemodels.Update(notemodel);
                Task.Run(() => userContext.SaveChanges());
                return "Note Updated";
            }
            else
            {
                return null;

            }
        }

        /// <summary>
        /// Trashes the specified noteid.
        /// </summary>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public Task Trash(int noteid)
        {
            try
            {
                var trashvar = this.userContext.Notemodels.Where(trash => trash.NoteID == noteid).SingleOrDefault();
                if (trashvar != null)
                {
                    trashvar.Trash = true;
                    return Task.Run(() => this.userContext.SaveChanges());
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Gets the trash.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public List<Notemodel> GetTrash()
        {
            try
            {
                var trashlist = this.userContext.Notemodels.Where(list => list.Trash == true).SingleOrDefault();
                if (trashlist != null)
                {
                    return this.userContext.Notemodels.Where(list => list.Trash == true).ToList<Notemodel>();
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Removes the trash.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public Task RemoveTrash(int NoteId)
        {
            try
            {
                var remove = this.userContext.Notemodels.Where(rm => rm.NoteID == NoteId).SingleOrDefault();
                if (remove != null)
                {
                    this.userContext.Notemodels.Remove(remove);
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        /// <summary>
        /// Restores the trash.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public Task RestoreTrash(int NoteId)
        {
            try
            {
                var restore = this.userContext.Notemodels.Where(res => res.NoteID == NoteId && res.Trash == true).SingleOrDefault();
                if (restore != null)
                {
                    restore.Trash = false;
                    return Task.Run(() => this.userContext.SaveChanges());
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Restores all trash.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public Task RestoreAllTrash(int NoteId)
        {
            try
            {
                var restoreall = from Notemodel in userContext.Notemodels where Notemodel.Trash == true select Notemodel;
                if (restoreall != null)
                {
                    foreach (var res in restoreall)
                    {
                        res.Trash = false;
                    }
                    return Task.Run(() => this.userContext.SaveChanges());
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Remainders the specified note identifier.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <param name="remainder">The remainder.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public int Remainder(int NoteId)
        {
            try
            {
                var remaind = this.userContext.Notemodels.Where(re => re.NoteID == NoteId).SingleOrDefault();
                if (remaind != null)
                {
                    remaind.Reminder = remaind.ToString();
                    return this.userContext.SaveChanges();
                }
                return 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int DeleteReminder(int id)
        {
            try
            {
                if (this.FindById(id))
                {
                    var note = this.userContext.Notemodels.Where(op => op.NoteID == id).SingleOrDefault();
                    var res = Task.Run(() => note.Reminder);
                    if (res != null && !res.Equals(string.Empty))
                    {
                        note.Reminder = string.Empty;
                        var result = this.userContext.SaveChanges();
                        return result;
                    }
                    return 0;
                }
                return 0;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private bool FindById(int id)
        {
            var result = this.userContext.Notemodels.Where(option => option.NoteID == id).SingleOrDefault();
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Archieves the specified note identifier.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Task Archieve(int NoteId)
        {
            try
            {
                var arch = this.userContext.Notemodels.Where(ar => ar.NoteID == NoteId).SingleOrDefault();
                if (arch != null)
                {
                    arch.Reminder = arch.ToString();
                    return Task.Run(() => this.userContext.SaveChanges());
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Uns the archieve.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public Task UnArchieve(int NoteId)
        {
            try
            {
                var unarch = this.userContext.Notemodels.Where(unar => unar.NoteID == NoteId && unar.Archive == true).SingleOrDefault();
                if (unarch != null)
                {
                    unarch.Archive = false;
                    return Task.Run(() => this.userContext.SaveChanges());
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Gets the archieve list.
        /// </summary>
        /// <param name="NoteId">The note identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public List<Notemodel> GetArchieveList()
        {
            try
            {
                var getarch = this.userContext.Notemodels.Where(getar => getar.Archive == true).SingleOrDefault();
                if (getarch != null)
                {
                    this.userContext.Notemodels.Where(list => list.Archive == true).ToList();
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Pins the specified noteid.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Task Pin(int Noteid)
        {
            try
            {
                var pinset = this.userContext.Notemodels.Where(p => p.NoteID == Noteid).SingleOrDefault();
                if (pinset != null)
                {
                    pinset.PinNote = true;
                    return Task.Run(() => this.userContext.SaveChanges());
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Task UnPin(int Noteid)
        {
            try
            {
                var pinset = this.userContext.Notemodels.Where(p => p.NoteID == Noteid).SingleOrDefault();
                if (pinset != null)
                {
                    pinset.PinNote = false;
                    return Task.Run(() => this.userContext.SaveChanges());
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Adds the color.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <param name="addcolor">The addcolor.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Task AddColor(int Noteid, string addcolor)
        {

            var color = this.userContext.Notemodels.Where(c => c.NoteID == Noteid).SingleOrDefault();
            if (color != null)
            {
                if (addcolor != null)
                {
                    color.AddColor = addcolor;
                    this.userContext.Notemodels.Update(color);
                    return Task.Run(() => this.userContext.SaveChanges());
                }

                else
                {
                    return null;
                }
            }
            throw new Exception();

        }

        /// <summary>
        /// Uploads the image.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <param name="img">The img.</param>
        /// <returns></returns>
        public string UploadImage(int Noteid, IFormFile img)
        {
            try
            {
                var filestream = img.OpenReadStream();
                var filename = img.FileName;
                ////Initializes a new instance of the CloudinaryDotNet.Account class.
                Account account = new Account("Venu Cloud name", "api key", "api secret");
                //// Initializes a new instance of the CloudinaryDotNet.Cloudinary class with Cloudinary account.
                Cloudinary cloudinary = new Cloudinary(account);
                var uploadfile = new ImageUploadParams()
                {
                    File = new FileDescription(filename, filestream)
                };
                var uploadimg = cloudinary.Upload(uploadfile);
                var imgresult = this.userContext.Notemodels.Where(im => im.NoteID == Noteid).SingleOrDefault();
                imgresult.AddImg = uploadimg.Uri.ToString();
                int count = 0;
                count = this.userContext.SaveChanges();
                return imgresult.AddImg;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<Notemodel>> GetAllNotes()
        {
            await this.userContext.SaveChangesAsync();
            var notes = this.userContext.Notemodels.GroupBy(op => op.Email).Select(grp => grp.ToList()).ToList();
            return this.userContext.Notemodels.ToList();
        }

        public List<Notemodel> Getallnote()
        {
            return this.userContext.Notemodels.ToList();
        }
    }
}
