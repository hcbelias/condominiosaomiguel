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

using System.Linq;
using Model;

namespace DAL
{
    public partial class Perfil
    {
    
    	public string ComboboxText{ get; set; }
    
    	public static Perfil GetPerfil(int p_Identifier)
    	{
    		DataContext v_Context = DataContext.GetContext();
            Perfil v_Data =
    					(from entity in v_Context.Perfil
                        where entity.Id == p_Identifier
    					select entity).FirstOrDefault();
    		if(v_Data!=null)
    			v_Data.setCombobox();
    		return v_Data;
    	}
    
    
    
    	public static ICollection<Perfil> ListPerfil()
    	{
    		DataContext v_Context = DataContext.GetContext();
    		List<Perfil> v_List =v_Context.Perfil.ToList();
    		for(int i=0; i < v_List.Count(); i++)
    		{
    			v_List[i].setCombobox();
    		}
    		return v_List;
    	}
    
    	
    
        public static void DeletePerfil(int p_Identifier)
        {
            DataContext v_Context = DataContext.GetContext();
            Perfil PerfilDAL = GetPerfil(p_Identifier);
            v_Context.DeleteObject(PerfilDAL);
        }
    
    
    	public static Perfil CreateFactory(Model.PerfilModel p_Model)
    	{
    		if(p_Model == null)
    			return new Perfil();
    		Perfil v_NewPerfil = new Perfil();
    		v_NewPerfil.Id = p_Model.Id;
    		v_NewPerfil.Name = p_Model.Name;
    		v_NewPerfil.ComboboxText = p_Model.ComboboxText;
    		return v_NewPerfil;
    	}
    
    	public static void Create(Model.PerfilModel p_Model)
    	{
    		DataContext v_Context = DataContext.GetContext();
    		Perfil v_NewPerfil = CreateFactory(p_Model);
    
    
    	}
    
    	public static void Edit(Model.PerfilModel p_Model)
    	{
    		if(p_Model == null || p_Model.Id == 0)
    			return;
    		DataContext v_Context = DataContext.GetContext();
    		Perfil v_Perfil = GetPerfil(p_Model.Id);
    		v_Perfil.updateFields(p_Model);
    }
    
    	
    	public void updateFields(PerfilModel p_Model)
        {
    		if(p_Model == null)
    			return ;
    
    		this.Name = p_Model.Name;
    	}
    
    
    	public void delete()
    	{
    		DataContext v_Context = DataContext.GetContext();
    		v_Context.DeleteObject(this);
    	}
    }
}
