using System;
using System.ComponentModel.DataAnnotations;
using CondominioSaoMiguel.Util;

namespace CondominioSaoMiguel.Models
{
    public class PhoneModel : BaseModel
    {
        public int DDD { get; set; }

        public int Phone { get; set; }
    }
}
