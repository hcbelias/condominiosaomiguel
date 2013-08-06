using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Model
{
    public abstract class BaseModel : IXmlSerializable, IModel
    {
        System.Xml.Schema.XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        void IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
        {

        }

        void IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
        {

        }

        [ScaffoldColumn(false)]
        public abstract int Id { get; set; }

        [ScaffoldColumn(false)]
        public abstract string ComboboxText { get; set; }


        public void setCombobox()
        {
            throw new NotImplementedException();
        }
    }
}
