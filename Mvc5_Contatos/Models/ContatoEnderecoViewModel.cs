using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5_Contatos.Models
{
    public class ContatoEnderecoViewModel
    {
        public int ContatoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Local { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}