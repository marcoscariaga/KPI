using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Modelos.ModeloEntrada
{
    public class AutenticacaoModelo
    {
        [EmailAddress(ErrorMessage = "Endereço de email inválido.")]
        [Required(ErrorMessage = "Informe o email do usuário.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário.")]
        public string Senha { get; set; }
    }
}
