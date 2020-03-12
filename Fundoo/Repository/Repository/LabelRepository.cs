using Model.Label;
using Repository.IRepository;
using Repository.UserDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository
{
    public class LabelRepository : ILabelRepository
    {
        private readonly UserContext userContext;
        public LabelRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }
        public string AddLabel(LabelModel labelModel)
        {
            LabelModel label = new LabelModel()
            {
                Emailid= labelModel.Emailid,
                Label= labelModel.Label
            };
            this.userContext.Label.Add(label);
            this.userContext.SaveChanges();
            return "Added";
        }

        public string DeleteLabel(int LabelID)
        {
            var Deletelabel = this.userContext.Label.Where(del => del.LabelID == LabelID).SingleOrDefault();
            if (Deletelabel != null)
            {
                this.userContext.Label.Remove(Deletelabel);
            }
            this.userContext.SaveChanges();
            return "Deleted";
        }

        public string UpdateLabel(LabelModel labelModel)
        {
            throw new NotImplementedException();
        }

        public List<LabelModel> GetLabelModels(int LabelID)
        {
            throw new NotImplementedException();
        }

    }
}
