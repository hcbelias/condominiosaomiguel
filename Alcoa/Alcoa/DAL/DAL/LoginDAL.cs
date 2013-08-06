using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace DAL
{
    public partial class Login : IModel
    {
        public void setCombobox()
        {
            this.ComboboxText = this.Id + " - " + this.Email;
        }

        public static Login GetLogin(string p_Email, string p_Password)
        {
            DataContext v_Context = DataContext.GetContext();
            return (from login in v_Context.Login
                    where login.Email == p_Email &&
                          login.Password == p_Password
                    select login).FirstOrDefault();
        }

        public static Login GetLogin(String p_Email)
        {
            DataContext v_Context = DataContext.GetContext();
            Login v_Data =
                        (from entity in v_Context.Login
                         where entity.Email == p_Email
                         select entity).FirstOrDefault();
            return v_Data;
        }
    }
}
