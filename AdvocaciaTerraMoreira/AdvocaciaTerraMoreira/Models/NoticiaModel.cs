using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvocaciaTerraMoreira.Models
{
    public class NoticiaModel
    {
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Resumo { get; set; }
        public string ImagemBase64 { get; set; }
        public string URl { get; set; }
    }
}