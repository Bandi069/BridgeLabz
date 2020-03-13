using Manager.InterfaceManager;
using Model.Label;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Manager
{
    /// <summary>
    /// This is Label Manager Class 
    /// </summary>
    public class LabelManager : IlabelManager
    {
        private readonly ILabelRepository labelRepository;
        /// <summary>
        /// This is Labelrepository dependency injection
        /// </summary>
        /// <param name="labelRepository"></param>
        public LabelManager(ILabelRepository labelRepository)
        {
            this.labelRepository = labelRepository;
        }
        /// <summary>
        /// This is AddLabel method for adding
        /// </summary>
        /// <param name="labelModle"></param>
        /// <returns></returns>
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
        /// <summary>
        /// This is DeleteLabel Method
        /// </summary>
        /// <param name="LabelID"></param>
        /// <returns></returns>
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
        /// <summary>
        /// This is for get label 
        /// </summary>
        /// <param name="LabelID"></param>
        /// <returns></returns>
        public List<LabelModel> GetLabel(int LabelID)
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
        /// <summary>
        /// This is for Updates Label
        /// </summary>
        /// <param name="labelModel"></param>
        /// <returns></returns>
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

