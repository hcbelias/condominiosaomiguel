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

namespace BLL.DTOQuery
{
    public partial class LoginDTOQuery
    {
        #region Navigation Properties
    
        public PerfilDTOQuery Perfil()
        {
            if (_perfil == null)
            {
                _perfil = new PerfilDTOQuery();
            }
            return _perfil;
        }
        public PerfilDTOQuery _perfil;

        #endregion
    }
}
