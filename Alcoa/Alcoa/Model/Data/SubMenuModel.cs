using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model
{
    [MetadataType(typeof(SubMenuModelMetadata))]
    public partial class SubMenuModel : IEquatable<SubMenuModel>
    {
        public bool Equals(SubMenuModel p_SubMenu)
        {
            return this.Name == p_SubMenu.Name &&
                this.Menu.Equals(p_SubMenu.Menu);
        }

        public override int GetHashCode()
        {
            int v_Hash = 17;
            v_Hash = v_Hash * 23 + this.Name.GetHashCode();
            return v_Hash;
        }

    }

    public class SubMenuModelMetadata
    {

    }


    public class SubMenuModelComparer : IEqualityComparer<List<SubMenuModel>>
    {

        public bool Equals(List<SubMenuModel> p_ListOne, List<SubMenuModel> p_ListTwo)
        {
            return p_ListOne.SequenceEqual(p_ListTwo);
        }

        public int GetHashCode(List<SubMenuModel> p_List)
        {
            int v_Hash = 17;

            foreach (var value in p_List)
                v_Hash = v_Hash * 23 + p_List.GetHashCode();

            return v_Hash;
        }
    }
}
