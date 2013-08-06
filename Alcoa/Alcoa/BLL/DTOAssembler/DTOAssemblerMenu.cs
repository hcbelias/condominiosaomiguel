using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using BLL.DTOQuery;
using DAL;
using Model;
using System.Linq;
namespace BLL.DTOAssembler
{
    public partial class MenuDTOAssembler
    {
    	public virtual ICollection<Model.MenuModel> Create(ICollection<Menu> p_ObjectListDAL, MenuDTOQuery p_Query)
    	{
    		return p_ObjectListDAL.Select(i_ObjectDAL => Create(i_ObjectDAL, p_Query)).Select(model => (MenuModel) model).ToList();
    	}
    
    	public virtual Model.MenuModel Create(Menu p_OriginalObj, MenuDTOQuery p_Query)
    	{
    		return Create(p_OriginalObj, null, p_Query);
    	}
    
    	public virtual Model.MenuModel Create(Menu p_OriginalObj, Model.MenuModel p_ReturnObj, MenuDTOQuery p_Query)
    	{
    		if (p_OriginalObj == null) return null;
    		
    		if(p_ReturnObj == null)
    		{
    			p_ReturnObj = new MenuModel();
    		}
    
    		#region Primitive Properties
    		p_ReturnObj.Id = p_OriginalObj.Id;
    		p_ReturnObj.Nome = p_OriginalObj.Nome;
    		p_ReturnObj.ClassName = p_OriginalObj.ClassName;
    		p_ReturnObj.ComboboxText = p_OriginalObj.ComboboxText;
    		#endregion
    
    		if(p_Query != null)
    		{
    
    			#region Complex Properties
    			#endregion
    
    			#region Navigation Properties
    			if (p_Query._subMenu != null)
    				p_ReturnObj.SubMenu = new SubMenuDTOAssembler().Create(p_OriginalObj.SubMenu, p_Query._subMenu);
    			#endregion
    		}
    		
    		return p_ReturnObj;
    	}
    }
}
