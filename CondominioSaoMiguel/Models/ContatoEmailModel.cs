using System;
using System.ComponentModel.DataAnnotations;
using CondominioSaoMiguel.Util;

namespace CondominioSaoMiguel.Models
{
    public class ContatoEmailModel
    {
        [Required(ErrorMessage = Constants.Messages.MSG_FIELD_REQUIRED)]
        public string Email { get; set; }

        [Required(ErrorMessage = Constants.Messages.MSG_FIELD_REQUIRED)]
        public string Name { get; set; }

        [Range(000, 999)]
        public int DDD { get; set; }

        [Range(000000000, 999999999)]
        public int Phone { get; set; }

        [Required(ErrorMessage = Constants.Messages.MSG_FIELD_REQUIRED)]
        public string Message { get; set; }
    }
}
