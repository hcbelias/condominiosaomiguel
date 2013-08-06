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
    public partial class SubMenuDTOAssembler
    {
    	public virtual ICollection<Model.SubMenuModel> Create(ICollection<SubMenu> p_ObjectListDAL, SubMenuDTOQuery p_Query)
    	{
    		return p_ObjectListDAL.Select(i_ObjectDAL => Create(i_ObjectDAL, p_Query)).Select(model => (SubMenuModel) model).ToList();
    	}
    
    	public virtual Model.SubMenuModel Create(SubMenu p_OriginalObj, SubMenuDTOQuery p_Query)
    	{
    		return Create(p_OriginalObj, null, p_Query);
    	}
    
    	public virtual Model.SubMenuModel Create(SubMenu p_OriginalObj, Model.SubMenuModel p_ReturnObj, SubMenuDTOQuery p_Query)
    	{
    		if (p_OriginalObj == null) return null;
    		
    		if(p_ReturnObj == null)
    		{
    			p_ReturnObj = new SubMenuModel();
    		}
    
    		#region Primitive Properties
    		p_ReturnObj.Id = p_OriginalObj.Id;
    		p_ReturnObj.Nome = p_OriginalObj.Nome;
    		p_ReturnObj.Link = p_OriginalObj.Link;
    		p_ReturnObj.ClassName = p_OriginalObj.ClassName;
    		p_ReturnObj.ComboboxText = p_OriginalObj.ComboboxText;
    		#endregion
    
    		if(p_Query != null)
    		{
    
    			#region Complex Properties
    			#endregion
    
    			#region Navigation Properties
    			if (p_Query._menu != null)
    				p_ReturnObj.Menu = new MenuDTOAssembler().Create(p_OriginalObj.Menu, p_Query._menu);
    			if (p_Query._perfil != null)
    				p_ReturnObj.Perfil = new PerfilDTOAssembler().Create(p_OriginalObj.Perfil, p_Query._perfil);
    			#endregion
    		}
    		
    		return p_ReturnObj;
    	}
    }
}
