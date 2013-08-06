using System;
using System.Web.Mvc;
using Model;
using Util.Attributes;
using Model;
using System.Collections.Generic;


namespace WebControllers
{
    [LogonAuthorize]
    public class ChartController : BaseController
    {
        [OutputCache(Duration = 200)]
        public override ActionResult Index()
        {
            return View("IndexChart");
        }

        public JsonResult Generate(IndexChartModel p_Model)
        {
            ChartModel v_Chart = DataController.Controllers.GetMasterData().GenerateChart(p_Model);
            return Json(new { Data = v_Chart }, JsonRequestBehavior.AllowGet);
        }

        public override ActionResult Create()
        {
            throw new NotImplementedException();
        }

        public override ActionResult Edit(int? p_Identifier)
        {
            throw new NotImplementedException();
        }

        public override ActionResult Delete(int p_Identifier)
        {
            throw new NotImplementedException();
        }

        public override ActionResult Info(int? p_Identifier)
        {
            throw new NotImplementedException();
        }
    }
}