using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chamaAi.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataDNascimento { get; set; }
        public int Senha { get; set; }
        public int ConfirmaSenha { get; set; }
        
    }
}