using Manager.InterfaceManager;
using Model.Label;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Manager
{
    public class LabelManager : IlabelManager
    {
        private readonly ILabelRepository labelRepository;
        public LabelManager(ILabelRepository labelRepository)
        {
            this.labelRepository = labelRepository;
        }
        public string AddLabel(LabelModel labelModle)
        {
            try
            {
                this.labelRepository.AddLabel(labelModle);
                return "Label Added";
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }

        public string DeleteLabel(int LabelID)
        {
            try
            {
                this.labelRepository.DeleteLabel(LabelID);
                return "Label Deleted";
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<LabelModel> GetLabelModels(int LabelID)
        {
            try
            {
                var getlist = new List<LabelModel>();
                var list= this.labelRepository.GetLabelModels(LabelID);
                foreach(var labellist in list)
                {
                    getlist.Add(labellist);
                }
                return getlist;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string UpdateLabel(LabelModel labelModel)
        {
            try
            {
                var update = this.labelRepository.UpdateLabel(labelModel);
                return update;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

