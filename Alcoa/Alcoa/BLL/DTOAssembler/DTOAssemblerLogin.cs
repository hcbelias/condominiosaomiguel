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
    public partial class LoginDTOAssembler
    {
    	public virtual ICollection<Model.LoginModel> Create(ICollection<Login> p_ObjectListDAL, LoginDTOQuery p_Query)
    	{
    		return p_ObjectListDAL.Select(i_ObjectDAL => Create(i_ObjectDAL, p_Query)).Select(model => (LoginModel) model).ToList();
    	}
    
    	public virtual Model.LoginModel Create(Login p_OriginalObj, LoginDTOQuery p_Query)
    	{
    		return Create(p_OriginalObj, null, p_Query);
    	}
    
    	public virtual Model.LoginModel Create(Login p_OriginalObj, Model.LoginModel p_ReturnObj, LoginDTOQuery p_Query)
    	{
    		if (p_OriginalObj == null) return null;
    		
    		if(p_ReturnObj == null)
    		{
    			p_ReturnObj = new LoginModel();
    		}
    
    		#region Primitive Properties
    		p_ReturnObj.Id = p_OriginalObj.Id;
    		p_ReturnObj.Password = p_OriginalObj.Password;
    		p_ReturnObj.Email = p_OriginalObj.Email;
    		p_ReturnObj.ComboboxText = p_OriginalObj.ComboboxText;
    		#endregion
    
    		if(p_Query != null)
    		{
    
    			#region Complex Properties
    			#endregion
    
    			#region Navigation Properties
    			if (p_Query._perfil != null)
    				p_ReturnObj.Perfil = new PerfilDTOAssembler().Create(p_OriginalObj.Perfil, p_Query._perfil);
    			#endregion
    		}
    		
    		return p_ReturnObj;
    	}
    }
}
