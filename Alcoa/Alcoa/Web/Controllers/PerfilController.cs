using System;
using System.Web.Mvc;
using System.Web.UI;
using Model;
using System.Linq;
using System.Collections.Generic;
using System.Web;
using System.Web.Caching;
using Web.UtilWeb;
namespace WebControllers
{
    public partial class PerfilController
    {
        #region Implementation of IBaseController

        new public ActionResult OnCreate(BaseModel p_Model)
        {
            DataController.MasterDataController v_DataController =
            DataController.Controllers.GetMasterData();
            v_DataController.CreatePerfil((PerfilModel)p_Model);
            return Index();
        }

        public ActionResult OnDelete(int p_Identifier)
        {
            DataController.MasterDataController v_DataController =
            DataController.Controllers.GetMasterData();
            v_DataController.DeletePerfil(p_Identifier);
            return Index();
        }

        public ActionResult OnEdit(BaseModel p_Model)
        {
            DataController.MasterDataController v_DataController =
            DataController.Controllers.GetMasterData();
            v_DataController.EditPerfil((PerfilModel)p_Model);
            return Index();
        }

        //public ActionResult OnException(Exception p_Exception)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        public static MenuModel ObterMenuModel()
        {
            DataController.MasterDataController v_Controller =
                DataController.Controllers.GetMasterData();
            if (UserManager.User == null)
            {
                return new MenuModel() { m_Login = new LoginModel() { Email = "Nenhum", Perfil = new PerfilModel() { Nome = "Desconectado" } } };
            }
            Model.LoginModel v_Login = v_Controller.GetLoginPeloEmail(UserManager.User.Email);
            if (v_Login == null)
            {
                return new MenuModel() { m_Login = new LoginModel() { Email = "Nenhum", Perfil = new PerfilModel() { Nome = "Desconectado" } } };
            }
            List<Model.MenuModel> v_MenuList = v_Login.Perfil.SubMenu.ToList()
                .Select(model => model.Menu).Distinct().ToList();

            List<DropdownModel> v_DropDownList = new List<DropdownModel>();
            foreach (var i_Menu in v_MenuList)
            {

                DropdownModel v_DropDown = new DropdownModel();
                v_DropDown.m_SubMenu = new List<DropDownSubMenuModel>();
                v_DropDown.m_DropDownMenu = i_Menu.Nome;
                v_DropDown.m_IconClS = i_Menu.ClassName;
                List<Model.SubMenuModel> v_SubMenuList = v_Login.Perfil.SubMenu
                    .Where(model => model.Menu.Nome == v_DropDown.m_DropDownMenu)
                        .ToList();

                foreach (var i_SubMenu in v_SubMenuList)
                {
                    DropDownSubMenuModel v_SubMenuDropDown = new DropDownSubMenuModel();
                    v_SubMenuDropDown.m_Titulo = i_SubMenu.Nome;
                    v_SubMenuDropDown.m_Link = i_SubMenu.Link;
                    v_SubMenuDropDown.m_IconClS = i_SubMenu.ClassName;
                    v_DropDown.m_SubMenu.Add(v_SubMenuDropDown);
                }
                v_DropDownList.Add(v_DropDown);
            }
            Model.MenuModel v_Model = new Model.MenuModel()
                {
                    m_DropDownMenu = v_DropDownList,
                    m_Login = v_Login
                };
            System.Web.HttpContext.Current.Session.Add("Menu_" + UserManager.User.Email, v_Model);

            return v_Model;
        }




    }
}