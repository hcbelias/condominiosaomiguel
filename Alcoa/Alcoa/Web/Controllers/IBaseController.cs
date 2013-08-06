using System;
using System.Web.Mvc;

namespace WebControllers
{
    interface IBaseController
    {
        ActionResult OnCreate(Model.BaseModel p_Model);
        ActionResult OnDelete(int p_Identifier);
        ActionResult OnEdit(Model.BaseModel p_Model);
        ActionResult OnException(Exception p_Exception);
        Model.BaseModel GetModel(Int32 p_Identifier);
    }
}
