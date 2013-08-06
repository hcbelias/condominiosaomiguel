//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

using DAL;
using Model;
using BLL.DTOAssembler;
using BLL.DTOQuery;

namespace BLL
{
    public partial class MenuBLL : BaseBLL
    {
    	DAL.Menu m_Data;
    
    	public MenuBLL(DAL.Menu p_Data)
    	{
    		this.m_Data = p_Data;
    	}
    
    	public override Model.BaseModel getModel()
    	{
    		if(this.m_Data == null)
    			return null;
    
    		Model.MenuModel v_Return = new Model.MenuModel();
    				v_Return.Id = this.m_Data.Id;
    		v_Return.Nome = this.m_Data.Nome;
    		v_Return.ClassName = this.m_Data.ClassName;
    		v_Return.ComboboxText = this.m_Data.ComboboxText;
    		return v_Return;
    	}
    
    	public Model.MenuModel getModelComplete()
    	{
    		Model.MenuModel v_Return = (Model.MenuModel) getModel();
    		if(v_Return == null)
    			return null;
    
    		v_Return.SubMenu = getSubMenu();
    		return v_Return;
    	}
    
    	internal List<SubMenuModel> getSubMenu()
    	{
    		List<SubMenuModel> v_Model = new List<SubMenuModel>();
    		if (v_Model != null && m_Data != null && m_Data.SubMenu!= null)
    		{
    			//v_Model = (SubMenuModel)(new BLL.SubMenuBLL(m_Data.SubMenu).getModel());
    		}
    		return v_Model;
    	}
    	public static MenuModel GetMenu(int p_Identifier)
    	{
    		Menu v_Data = Menu.GetMenu(p_Identifier);
            return  ( MenuModel)(new BLL.MenuBLL(v_Data).getModelComplete());
    	}
    
    	public static MenuModel GetMenu(int p_Identifier, MenuDTOQuery p_Query)
    	{
    		Menu v_Data = Menu.GetMenu(p_Identifier);
    		return (new MenuDTOAssembler()).Create(v_Data, null, p_Query);
    	}
    
    	public static ICollection<MenuModel> ListMenu()
    	{
    		ICollection<MenuModel> v_ReturnList = new Collection<MenuModel>();
    		ICollection<Menu> v_Data = Menu.ListMenu();
    		IEnumerator v_Enumerator = v_Data.GetEnumerator();
    		while (v_Enumerator.MoveNext())
    		{
    			v_ReturnList.Add((new MenuDTOAssembler()).Create((Menu)v_Enumerator.Current, null, null));
    		}
    		return v_ReturnList;
    	}
    
    	private static MenuModel CreateModel(Menu v_Data)
        {
            return (MenuModel) (new BLL.MenuBLL(v_Data)).getModelComplete();
        }
    
    	public static void DeleteMenu(int p_Identifier)
    	{
    		Menu.DeleteMenu(p_Identifier);
    	}
    
    	public static void CreateMenu(MenuModel p_Model)
    	{
    		DAL.Menu.Create(p_Model);
    	}
    
    	public static void EditMenu(MenuModel p_Model)
    	{
    		DAL.Menu.Edit(p_Model);
    	}
    }
}
