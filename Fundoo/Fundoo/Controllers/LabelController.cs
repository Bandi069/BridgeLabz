using Manager.InterfaceManager;
using Microsoft.AspNetCore.Mvc;
using Model.Label;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundoo.Controllers
{
    /// <summary>
    /// This is Label Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public class LabelController : ControllerBase
    {
        /// <summary>
        /// The label manager
        /// </summary>
        private readonly ILabelManager labelManager;
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelController"/> class.
        /// </summary>
        /// <param name="labelManager">The label manager.</param>
        public LabelController(ILabelManager labelManager)
        {
            this.labelManager = labelManager;
        }
        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("addlabel")]
        public ActionResult AddLabel(LabelModel labelModel)
        {
            try
            {
                var add = this.labelManager.AddLabel(labelModel);
                return Ok(add);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="labelid">The labelid.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("deletelabel")]
        public ActionResult DeleteLabel(int labelid)
        {
            try
            {
                var delete = this.labelManager.DeleteLabel(labelid);
                return Ok(delete);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("updatelabel")]
        public ActionResult UpdateLabel(LabelModel labelModel)
        {
            try
            {
                var update = this.labelManager.UpdateLabel(labelModel);
                return Ok(update);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="Labelid">The labelid.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet]
        [Route("show")]
        public List<LabelModel> GetLabel(int Labelid)
        {
            try
            {
                return this.labelManager.GetLabel(Labelid);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
