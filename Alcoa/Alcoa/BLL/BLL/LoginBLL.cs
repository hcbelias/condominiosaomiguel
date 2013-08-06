using DAL;
using Model;
using System.Linq;

namespace BLL
{
    public partial class LoginBLL
    {
        public static LoginModel GetLogin(string p_Email, string p_Password)
        {
            Login v_Data = Login.GetLogin(p_Email, p_Password);
            if (v_Data == null)
                return null;
            return (LoginModel)(new BLL.LoginBLL(v_Data)).getModelComPerfil();
        }

        public static LoginModel GetLoginPeloEmail(string p_Email)
        {
            Login v_Data = Login.GetLogin(p_Email);
            if (v_Data == null)
                return null;
            return (LoginModel)(new BLL.LoginBLL(v_Data)).getModelComPerfilMenuESubMenu();
        }

        public LoginModel getModelComPerfil()
        {
            LoginModel v_Model = new LoginModel();
            v_Model = (LoginModel)getModel();
            v_Model.Perfil = (PerfilModel)(new BLL.PerfilBLL(m_Data.Perfil)).getModel();
            return v_Model;
        }

        public LoginModel getModelComPerfilMenuESubMenu()
        {
            LoginModel v_Model = getModelComPerfil();

            if (v_Model.Perfil != null)
            {
                v_Model.Perfil.SubMenu =
                    m_Data.Perfil.SubMenu.Select(model => (SubMenuModel)(new BLL.SubMenuBLL(model)).getModelComMenu())
                          .ToList();
            }
            return v_Model;
        }
    }
}
