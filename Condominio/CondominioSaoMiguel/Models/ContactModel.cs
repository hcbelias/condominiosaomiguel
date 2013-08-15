using System;
using System.ComponentModel.DataAnnotations;

using UtilWeb;

namespace CondominioSaoMiguel.Models
{
    public class ContactModel : BaseModel
    {
        [Required(ErrorMessage= "Necessário informar um e-mail válido - example@example.com")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Necessário informar um e-mail válido - example@example.com")]
        public string Email { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo 'Nome' obrigatório")]
        public string Name { get; set; }

        [Range(000, 999)]
        [Display(Name = "DDD")]
        public int? DDD { get; set; }

        [Range(000000000, 999999999)]
        [Display(Name = "Telefone")]
        public int? Phone { get; set; }

        [Display(Name = "Mensagem")]
        [Required(ErrorMessage = "Campo 'Mensagem' obrigatório")]
        public string Message { get; set; }
    }
}
