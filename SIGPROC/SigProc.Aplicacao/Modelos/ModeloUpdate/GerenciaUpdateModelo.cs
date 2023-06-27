using SigProc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Modelos
{
    public class GerenciaUpdateModelo 
    {

        public int? Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string? Sigla { get; set; }
        public int Prazo { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public int IdUsuarioResp { get; set; }
        public bool Status { get; set; }
    }
}
