using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Modelos.ModeloEntrada
{
    public class UsuarioModelo
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string? Matricula { get; set; }
        public DateTime? DataNasc { get; set; }
        public string? Sexo { get; set; }
        public string Senha { get; set; }
    }
}
