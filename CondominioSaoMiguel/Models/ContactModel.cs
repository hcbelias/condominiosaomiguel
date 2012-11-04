using System;
using System.ComponentModel.DataAnnotations;
using CondominioSaoMiguel.Util;

namespace CondominioSaoMiguel.Models
{
    public class ContactModel : BaseModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Nome")]
        [Required]
        public string Name { get; set; }

        [Range(000, 999)]
        [Display(Name = "DDD")]
        public int? DDD { get; set; }

        [Range(000000000, 999999999)]
        [Display(Name = "Telefone")]
        public int? Phone { get; set; }

        [Display(Name = "Mensagem")]
        [Required]
        public string Message { get; set; }
    }
}
