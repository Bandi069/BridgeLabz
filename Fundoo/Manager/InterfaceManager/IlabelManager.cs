using Model.Label;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.InterfaceManager
{
   public interface IlabelManager
    {
        string AddLabel(LabelModel labelModle);
        string DeleteLabel(int LabelID);
        string UpdateLabel(LabelModel labelModel);
        List<LabelModel> GetLabelModels(int LabelID);
    }
}
