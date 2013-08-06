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
    public partial class Login
    {
    
    	public string ComboboxText{ get; set; }
    
    	public static Login GetLogin(int p_Identifier)
    	{
    		DataContext v_Context = DataContext.GetContext();
            Login v_Data =
    					(from entity in v_Context.Login
                        where entity.Id == p_Identifier
    					select entity).FirstOrDefault();
    		if(v_Data!=null)
    			v_Data.setCombobox();
    		return v_Data;
    	}
    
    
    
    	public static ICollection<Login> ListLogin()
    	{
    		DataContext v_Context = DataContext.GetContext();
    		List<Login> v_List =v_Context.Login.ToList();
    		for(int i=0; i < v_List.Count(); i++)
    		{
    			v_List[i].setCombobox();
    		}
    		return v_List;
    	}
    
    	
    
        public static void DeleteLogin(int p_Identifier)
        {
            DataContext v_Context = DataContext.GetContext();
            Login LoginDAL = GetLogin(p_Identifier);
            v_Context.DeleteObject(LoginDAL);
        }
    
    
    	public static Login CreateFactory(Model.LoginModel p_Model)
    	{
    		if(p_Model == null)
    			return new Login();
    		Login v_NewLogin = new Login();
    		v_NewLogin.Id = p_Model.Id;
    		v_NewLogin.Password = p_Model.Password;
    		v_NewLogin.Email = p_Model.Email;
            if (p_Model.Perfil != null)
    			v_NewLogin.Perfil = Perfil.GetPerfil(p_Model.Perfil.Id);
    		if (v_NewLogin.Perfil == null)
    			throw new Exception("Entidade Login deve ter um(a) Perfil associado.");
    		v_NewLogin.ComboboxText = p_Model.ComboboxText;
    		return v_NewLogin;
    	}
    
    	public static void Create(Model.LoginModel p_Model)
    	{
    		DataContext v_Context = DataContext.GetContext();
    		Login v_NewLogin = CreateFactory(p_Model);
    
    
    	}
    
    	public static void Edit(Model.LoginModel p_Model)
    	{
    		if(p_Model == null || p_Model.Id == 0)
    			return;
    		DataContext v_Context = DataContext.GetContext();
    		Login v_Login = GetLogin(p_Model.Id);
    		v_Login.updateFields(p_Model);
    }
    
    	
    	public void updateFields(LoginModel p_Model)
        {
    		if(p_Model == null)
    			return ;
    
    		this.Password = p_Model.Password;
    		this.Email = p_Model.Email;
    	}
    
    
    	public void delete()
    	{
    		DataContext v_Context = DataContext.GetContext();
    		v_Context.DeleteObject(this);
    	}
    }
}
