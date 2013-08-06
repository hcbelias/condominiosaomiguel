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
    public partial class PerfilDTOAssembler
    {
    	public virtual ICollection<Model.PerfilModel> Create(ICollection<Perfil> p_ObjectListDAL, PerfilDTOQuery p_Query)
    	{
    		return p_ObjectListDAL.Select(i_ObjectDAL => Create(i_ObjectDAL, p_Query)).Select(model => (PerfilModel) model).ToList();
    	}
    
    	public virtual Model.PerfilModel Create(Perfil p_OriginalObj, PerfilDTOQuery p_Query)
    	{
    		return Create(p_OriginalObj, null, p_Query);
    	}
    
    	public virtual Model.PerfilModel Create(Perfil p_OriginalObj, Model.PerfilModel p_ReturnObj, PerfilDTOQuery p_Query)
    	{
    		if (p_OriginalObj == null) return null;
    		
    		if(p_ReturnObj == null)
    		{
    			p_ReturnObj = new PerfilModel();
    		}
    
    		#region Primitive Properties
    		p_ReturnObj.Id = p_OriginalObj.Id;
    		p_ReturnObj.Nome = p_OriginalObj.Nome;
    		p_ReturnObj.ComboboxText = p_OriginalObj.ComboboxText;
    		#endregion
    
    		if(p_Query != null)
    		{
    
    			#region Complex Properties
    			#endregion
    
    			#region Navigation Properties
    			if (p_Query._login != null)
    				p_ReturnObj.Login = new LoginDTOAssembler().Create(p_OriginalObj.Login, p_Query._login);
    			if (p_Query._subMenu != null)
    				p_ReturnObj.SubMenu = new SubMenuDTOAssembler().Create(p_OriginalObj.SubMenu, p_Query._subMenu);
    			#endregion
    		}
    		
    		return p_ReturnObj;
    	}
    }
}
