using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model
{
    public interface IModel
    {
        int Id { get; set; }

        String ComboboxText { get; set; }

        void setCombobox();
    }
}
