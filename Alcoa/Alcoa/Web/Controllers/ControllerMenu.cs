
	
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
    public partial class MenuController : BaseController, IBaseController
    {
		[OutputCache(Duration = 200)]
        public override ActionResult Index()
        {
            return View("IndexMenu", new List<MenuModel>());
        }
		[OutputCache(Duration = 200)]
        public override ActionResult Create()
        {
            return View("CreateMenu");
        } 

        [HttpPost]
        public ActionResult Create([Bind(Exclude="Id")]Model.MenuModel p_Model)
        {
            
            return OnCreate(p_Model);
            
        }

        public override ActionResult Edit(int? p_Identifier)
        {
			if(TempData["Message"] != null)
			{
	            SetSuccessMessage((string)TempData["Message"]);
			}
			if(TempData["Menu"] != null)
			{
				return View("EditMenu", (Model.MenuModel)TempData["Menu"]);
			}
			if(!p_Identifier.HasValue || p_Identifier.Value == 0)
				return Create();
            return View("EditMenu", (MenuModel)GetModel(p_Identifier.Value));
        }

		public override ActionResult Info(int? p_Identifier)
        {
		if(!p_Identifier.HasValue || p_Identifier.Value == 0)
				return Create();
            return View("MenuInfo", (MenuModel)GetModelInfo(p_Identifier.Value));
        }


        [HttpPost]
        public ActionResult Edit(Model.MenuModel p_Model)
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
            ICollection<Model.MenuModel> MenuModelList = v_DataController.ListMenu();
            if (MenuModelList.Count == 0)
                return new List<SelectListItem>();

            List<SelectListItem> selectItemList = new List<SelectListItem>();
            bool hasDefault = false;
            foreach (Model.MenuModel i_Model in MenuModelList)
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







   