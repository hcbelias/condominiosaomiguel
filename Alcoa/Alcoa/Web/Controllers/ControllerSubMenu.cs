
	
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataController;
using Model;
using Util.Attributes;

namespace WebControllers
{
	
	[LogonAuthorize]
    public partial class SubMenuController : BaseController, IBaseController
    {
		[OutputCache(Duration = 200)]
        public override ActionResult Index()
        {
            return View("IndexSubMenu", new List<SubMenuModel>());
        }
		[OutputCache(Duration = 200)]
        public override ActionResult Create()
        {
            return View("CreateSubMenu");
        } 

        [HttpPost]
        public ActionResult Create([Bind(Exclude="Id")]Model.SubMenuModel p_Model)
        {
            
            return OnCreate(p_Model);
            
        }

        public override ActionResult Edit(int? p_Identifier)
        {
			if(TempData["Message"] != null)
			{
	            SetSuccessMessage((string)TempData["Message"]);
			}
			if(TempData["SubMenu"] != null)
			{
				return View("EditSubMenu", (Model.SubMenuModel)TempData["SubMenu"]);
			}
			if(!p_Identifier.HasValue || p_Identifier.Value == 0)
				return Create();
            return View("EditSubMenu", (SubMenuModel)GetModel(p_Identifier.Value));
        }

		public override ActionResult Info(int? p_Identifier)
        {
		if(!p_Identifier.HasValue || p_Identifier.Value == 0)
				return Create();
            return View("SubMenuInfo", (SubMenuModel)GetModelInfo(p_Identifier.Value));
        }


        [HttpPost]
        public ActionResult Edit(Model.SubMenuModel p_Model)
        {
            return OnEdit(p_Model);        
        }


        public override ActionResult Delete(int p_Identifier)
        {
			if(TempData["Message"] != null)
			{
	            SetSuccessMessage((string)TempData["Message"]);
			}
            return OnDelete(p_Identifier);
        }

		
        public static List<SelectListItem> GetComboBox(int p_Identifier)
        {
			DataController.MasterDataController v_DataController = DataController.Controllers.GetMasterData();
            ICollection<Model.SubMenuModel> SubMenuModelList = v_DataController.ListSubMenu();
            if (SubMenuModelList.Count == 0)
                return new List<SelectListItem>();

            List<SelectListItem> selectItemList = new List<SelectListItem>();
            bool hasDefault = false;
            foreach (Model.SubMenuModel i_Model in SubMenuModelList)
            {
                SelectListItem listItem = new SelectListItem();
                listItem.Value = i_Model.Id.ToString();
				listItem.Text = i_Model.ComboboxText;
                if (i_Model.Id == p_Identifier && hasDefault == false)
                {
                    listItem.Selected = true;
                    hasDefault = true;
                }
                else
                    listItem.Selected = false;
                selectItemList.Add(listItem);
            }
            if (!hasDefault)
            {
                    selectItemList[0].Selected = true;
            }
            return selectItemList;
        }


    }
}







   