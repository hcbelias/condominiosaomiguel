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
    public partial class SubMenu
    {
    
    	public string ComboboxText{ get; set; }
    
    	public static SubMenu GetSubMenu(int p_Identifier)
    	{
    		DataContext v_Context = DataContext.GetContext();
            SubMenu v_Data =
    					(from entity in v_Context.SubMenu
                        where entity.Id == p_Identifier
    					select entity).FirstOrDefault();
    		if(v_Data!=null)
    			v_Data.setCombobox();
    		return v_Data;
    	}
    
    
    
    	public static ICollection<SubMenu> ListSubMenu()
    	{
    		DataContext v_Context = DataContext.GetContext();
    		List<SubMenu> v_List =v_Context.SubMenu.ToList();
    		for(int i=0; i < v_List.Count(); i++)
    		{
    			v_List[i].setCombobox();
    		}
    		return v_List;
    	}
    
    	
    
        public static void DeleteSubMenu(int p_Identifier)
        {
            DataContext v_Context = DataContext.GetContext();
            SubMenu SubMenuDAL = GetSubMenu(p_Identifier);
            v_Context.DeleteObject(SubMenuDAL);
        }
    
    
    	public static SubMenu CreateFactory(Model.SubMenuModel p_Model)
    	{
    		if(p_Model == null)
    			return new SubMenu();
    		SubMenu v_NewSubMenu = new SubMenu();
    		v_NewSubMenu.Id = p_Model.Id;
    		v_NewSubMenu.Nome = p_Model.Nome;
    		v_NewSubMenu.Link = p_Model.Link;
    		v_NewSubMenu.ClassName = p_Model.ClassName;
            if (p_Model.Menu != null)
    			v_NewSubMenu.Menu = Menu.GetMenu(p_Model.Menu.Id);
    		if (v_NewSubMenu.Menu == null)
    			throw new Exception("Entidade SubMenu deve ter um(a) Menu associado.");
    		v_NewSubMenu.ComboboxText = p_Model.ComboboxText;
    		return v_NewSubMenu;
    	}
    
    	public static void Create(Model.SubMenuModel p_Model)
    	{
    		DataContext v_Context = DataContext.GetContext();
    		SubMenu v_NewSubMenu = CreateFactory(p_Model);
    
    
    	}
    
    	public static void Edit(Model.SubMenuModel p_Model)
    	{
    		if(p_Model == null || p_Model.Id == 0)
    			return;
    		DataContext v_Context = DataContext.GetContext();
    		SubMenu v_SubMenu = GetSubMenu(p_Model.Id);
    		v_SubMenu.updateFields(p_Model);
    }
    
    	
    	public void updateFields(SubMenuModel p_Model)
        {
    		if(p_Model == null)
    			return ;
    
    		this.Nome = p_Model.Nome;
    		this.Link = p_Model.Link;
    		this.ClassName = p_Model.ClassName;
    	}
    
    
    	public void delete()
    	{
    		DataContext v_Context = DataContext.GetContext();
    		v_Context.DeleteObject(this);
    	}
    }
}