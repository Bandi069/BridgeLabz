using Model.Label;
using Repository.IRepository;
using Repository.UserDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class LabelRepository : ILabelRepository
    {
        /// <summary>
        /// The user context
        /// </summary>
        private readonly UserContext userContext;
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelRepository"/> class.
        /// </summary>
        /// <param name="userContext">The user context.</param>
        public LabelRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }
        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        public string AddLabel(LabelModel labelModel)
        {
            try
            {
                LabelModel label = new LabelModel()
                {
                    LabelID = labelModel.LabelID,
                    NoteId = labelModel.NoteId,
                    Email = labelModel.Email,
                    Label = labelModel.Label
                };
                this.userContext.Label.Add(label);
                this.userContext.SaveChanges();
                return "Label Added";
            }
            catch(Exception e )
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="LabelID">The label identifier.</param>
        /// <returns></returns>
        public string DeleteLabel(int LabelID)
        {
            var Deletelabel = this.userContext.Label.Where(del => del.LabelID == LabelID).SingleOrDefault();
            if (Deletelabel != null)
            {
                this.userContext.Label.Remove(Deletelabel);

                this.userContext.SaveChanges();
                return "Deleted";
            }
            else { return null; }
        }
        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        public string UpdateLabel(int LabelID, string name)
        {

            var update = this.userContext.Label.Where(up => up.LabelID == LabelID).SingleOrDefault();
            if (update != null)
            {
                  update.Label = name;
                //  update.Email = labelModel.Email;
               // update.Label = Label;

                this.userContext.Label.Update(update);
                this.userContext.SaveChanges();
                return "Updated";
            }
            else { return default; }
        }
        /// <summary>
        /// Gets the label models.
        /// </summary>
        /// <param name="LabelID">The label identifier.</param>
        /// <returns></returns>
        public List<LabelModel> GetLabelModels(int LabelID)
        {
            var getlabel = this.userContext.Label.Where(get => get.LabelID == LabelID).SingleOrDefault();
            if(getlabel!=null)
            {
                return this.userContext.Label.Where(get => get.LabelID == LabelID).ToList();
            }
            return null;
        }
        public async Task<List<LabelModel>> GetAllLabels()
        {
            await this.userContext.SaveChangesAsync();
            return this.userContext.Label.ToList<LabelModel>();
        }
    }
}
