using SigProc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Dominio.Entidades
{
    public class GerenciaPrazo : Base
    {
        public int IdGerencia { get; set; }
        public int IdTipoPrazo { get; set; }
        
        //Alterar IdTipoContratacao para IdTipoModalidade
        public int? IdTipoContratacao { get; set; }
        public int? IdTipoProcesso { get; set; }
        public int? IdEtapaProcesso { get; set; }
        public int Prazo { get; set; }
        public int IdUsuarioCadastro { get; set; }

        public virtual Gerencia Gerencia { get; set; }

        //Alterar o nome TipoContratacao para TipoModalidade
        public virtual TipoContratacao TipoContratacao { get; set; }
        public virtual TipoProcesso TipoProcesso { get; set; }
        public virtual TipoPrazo TipoPrazo { get; set; }
        public virtual EtapaProcesso EtapaProcesso { get; set; }
    }
}
