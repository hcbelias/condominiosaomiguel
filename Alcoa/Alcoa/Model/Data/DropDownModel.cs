using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class DropdownModel
    {
        public String m_DropDownMenu;

        public String m_IconClS;

        public List<DropDownSubMenuModel> m_SubMenu;

    }

    public class DropDownSubMenuModel
    {
        public String m_Titulo;

        public String m_Link;

        public String m_IconClS;
    }
}