using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AdvocaciaTerraMoreira.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Necessário informar um e-mail válido - example@example.com")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Necessário informar um e-mail válido - example@example.com")]
        public string Email { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo 'Nome' obrigatório")]
        public string Name { get; set; }

        [Display(Name = "DDD")]
        public string DDD { get; set; }

        [Display(Name = "Telefone")]
        public string Phone { get; set; }

        [Display(Name = "Mensagem")]
        [Required(ErrorMessage = "Campo 'Mensagem' obrigatório")]
        public string Message { get; set; }

    }
}