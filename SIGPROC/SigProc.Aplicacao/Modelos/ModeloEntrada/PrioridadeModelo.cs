using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Modelos
{
    public class PrioridadeModelo
    {
        public int IdTramitacao { get; set; }
        public string Descricao { get; set; }
        public int IdGerencia { get; set; }
        public int? IdProcesso { get; set; }
        public int IdUsuario { get; set; }
        public string? StatusProcesso { get; set; }

    }

    public class TramitacaoEtapaProcesso
    {
        public int IdEtapa { get; set; }
        public int IdTramitacao { get; set; }
        public int IdOrgaoDestino { get; set; }
    }
}
