using System;
using System.ComponentModel.DataAnnotations;


namespace CondominioSaoMiguel.Models
{
    public class PhoneModel : BaseModel
    {
        public int DDD { get; set; }

        public int Phone { get; set; }
    }
}
