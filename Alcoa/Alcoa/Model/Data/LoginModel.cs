using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Util.Attributes;

namespace Model
{
    [MetadataType(typeof(LoginModelMetadata))]
    public partial class LoginModel
    {

    }

    public class LoginModelMetadata
    {

        [DataType(DataType.EmailAddress)]
        [Email]
        public string Email
        {
            get;
            set;

        }

    }
}
