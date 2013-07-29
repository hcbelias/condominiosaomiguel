using System;
using System.ComponentModel.DataAnnotations;
using Web.Util;

namespace Web.Models
{
    public class PhoneModel : BaseModel
    {
        public int DDD { get; set; }

        public int Phone { get; set; }
    }
}
