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
    public partial class CidadeDTOAssembler
    {
    	public virtual ICollection<Model.CidadeModel> Create(ICollection<Cidade> p_ObjectListDAL, CidadeDTOQuery p_Query)
    	{
    		return p_ObjectListDAL.Select(i_ObjectDAL => Create(i_ObjectDAL, p_Query)).Select(model => (CidadeModel) model).ToList();
    	}
    
    	public virtual Model.CidadeModel Create(Cidade p_OriginalObj, CidadeDTOQuery p_Query)
    	{
    		return Create(p_OriginalObj, null, p_Query);
    	}
    
    	public virtual Model.CidadeModel Create(Cidade p_OriginalObj, Model.CidadeModel p_ReturnObj, CidadeDTOQuery p_Query)
    	{
    		if (p_OriginalObj == null) return null;
    		
    		if(p_ReturnObj == null)
    		{
    			p_ReturnObj = new CidadeModel();
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
    			if (p_Query._estado != null)
    				p_ReturnObj.Estado = new EstadoDTOAssembler().Create(p_OriginalObj.Estado, p_Query._estado);
    			#endregion
    		}
    		
    		return p_ReturnObj;
    	}
    }
}
