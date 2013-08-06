using DAL;
using Model;

namespace BLL
{
    public partial class SubMenuBLL
    {
        internal SubMenuModel getModelComMenu()
        {
            SubMenuModel v_Model = (SubMenuModel)getModel();
            v_Model.Menu = (MenuModel)(new BLL.MenuBLL(m_Data.Menu).getModel());
            return v_Model;
        }
    }
}
