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
            throw new NotImplementedException();
        }

        public string DeleteLabel(int LabelID)
        {
            throw new NotImplementedException();
        }

        public List<LabelModel> GetLabelModels(int LabelID)
        {
            throw new NotImplementedException();
        }

        public string UpdateLabel(LabelModel labelModel)
        {
            throw new NotImplementedException();
        }
    }
}

