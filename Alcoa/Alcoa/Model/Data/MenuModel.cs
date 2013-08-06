using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model
{
    [MetadataType(typeof(MenuModelMetadata))]
    public partial class MenuModel : IEquatable<MenuModel>
    {

        public bool Equals(MenuModel p_Menu)
        {
            return this.Name == p_Menu.Name;
        }

        public override int GetHashCode()
        {
            int v_Hash = 17;
            v_Hash = v_Hash * 23 + this.Name.GetHashCode();
            return v_Hash;
        }

        public List<DropdownModel> m_DropDownMenu { get; set; }

        public LoginModel m_Login { get; set; }
    }

    public class MenuModelMetadata
    {

    }

    public class MenuModelComparer : IEqualityComparer<List<MenuModel>>
    {
        #region IEqualityComparer<List<SupplierCategory>> Members

        public bool Equals(List<MenuModel> p_ListOne, List<MenuModel> p_ListTwo)
        {
            return p_ListOne.SequenceEqual(p_ListTwo);
        }

        public int GetHashCode(List<MenuModel> p_List)
        {
            int v_Hash = 17;

            foreach (var value in p_List)
                v_Hash = v_Hash * 23 + p_List.GetHashCode();

            return v_Hash;
        }

        #endregion
    }
}
