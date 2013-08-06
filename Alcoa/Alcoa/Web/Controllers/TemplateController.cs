using System;
using System.Web.Mvc;
using Model;

namespace WebControllers
{
    public partial class TemplateController
    {
        #region Implementation of IBaseController

        //new public ActionResult OnCreate(BaseModel p_Model)
        //{
        //    DataController.MasterDataController v_DataController =
        //    DataController.Controllers.GetMasterData();
        //    v_DataController.CreateAcquire((AcquireModel)p_Model);
        //    return Index();
        //}

        //public ActionResult OnDelete(int p_Identifier)
        //{
        //    DataController.MasterDataController v_DataController =
        //    DataController.Controllers.GetMasterData();
        //    v_DataController.DeleteAcquire(p_Identifier);
        //    return Index();
        //}

        //public ActionResult OnEdit(BaseModel p_Model)
        //{
        //    DataController.MasterDataController v_DataController =
        //    DataController.Controllers.GetMasterData();
        //    v_DataController.EditAcquire((AcquireModel)p_Model);
        //    return Index();
        //}

        //public ActionResult OnException(Exception p_Exception)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion
    }
}