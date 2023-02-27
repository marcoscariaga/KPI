using SigProc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Dominio.Entidades
{
    public class Gerencia : Base
    {
        public string Descricao { get; set; }
        public int Prazo { get; set; }
        public int Id_Responsavel { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public bool Status { get; set; }

        public virtual Usuario Usuario { get; set; }

    }
}
