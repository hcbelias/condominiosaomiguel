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
using BLL;

namespace DataController
{
    public partial class MasterDataController
    {
    
    	public LoginModel GetLogin(int p_Identifier)
    	{
    		return BLL.LoginBLL.GetLogin(p_Identifier);
    	}
    
    	public LoginModel GetLogin(int p_Identifier, BLL.DTOQuery.LoginDTOQuery p_LoginQuery)
        {
            return BLL.LoginBLL.GetLogin(p_Identifier, p_LoginQuery);
        }
    
    	public ICollection<LoginModel> ListLogin()
    	{
    		return BLL.LoginBLL.ListLogin();
    	}
    
    	public void DeleteLogin(int p_Identifier)
    	{
    		BLL.LoginBLL.DeleteLogin(p_Identifier);
    	}
    
    	public void CreateLogin(LoginModel p_Model)
    	{
    		BLL.LoginBLL.CreateLogin(p_Model);
    	}
    
    	public void EditLogin(LoginModel p_Model)
    	{
    		BLL.LoginBLL.EditLogin(p_Model);
    	}
    
    }
}
