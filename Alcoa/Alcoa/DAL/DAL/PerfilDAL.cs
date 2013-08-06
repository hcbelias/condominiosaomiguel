using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace DAL
{
    public partial class Perfil : IModel
    {
        public void setCombobox()
        {
            this.ComboboxText = this.Nome;
        }
    }
}
