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
    public partial class EstadoDTOAssembler
    {
    	public virtual ICollection<Model.EstadoModel> Create(ICollection<Estado> p_ObjectListDAL, EstadoDTOQuery p_Query)
    	{
    		return p_ObjectListDAL.Select(i_ObjectDAL => Create(i_ObjectDAL, p_Query)).Select(model => (EstadoModel) model).ToList();
    	}
    
    	public virtual Model.EstadoModel Create(Estado p_OriginalObj, EstadoDTOQuery p_Query)
    	{
    		return Create(p_OriginalObj, null, p_Query);
    	}
    
    	public virtual Model.EstadoModel Create(Estado p_OriginalObj, Model.EstadoModel p_ReturnObj, EstadoDTOQuery p_Query)
    	{
    		if (p_OriginalObj == null) return null;
    		
    		if(p_ReturnObj == null)
    		{
    			p_ReturnObj = new EstadoModel();
    		}
    
    		#region Primitive Properties
    		p_ReturnObj.Id = p_OriginalObj.Id;
    		p_ReturnObj.Nome = p_OriginalObj.Nome;
    		p_ReturnObj.Sigla = p_OriginalObj.Sigla;
    		p_ReturnObj.ComboboxText = p_OriginalObj.ComboboxText;
    		#endregion
    
    		if(p_Query != null)
    		{
    
    			#region Complex Properties
    			#endregion
    
    			#region Navigation Properties
    			if (p_Query._cidade != null)
    				p_ReturnObj.Cidade = new CidadeDTOAssembler().Create(p_OriginalObj.Cidade, p_Query._cidade);
    			#endregion
    		}
    		
    		return p_ReturnObj;
    	}
    }
}
