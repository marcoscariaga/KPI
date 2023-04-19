using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Modelos.ModeloSaida
{
    public class TotalDashboardModelo
    {
        public string Prioridade { get; set; }
        public string Gerencia { get; set; }
        public int Quantidade { get; set; }
    }

    public class TotalProcessoPorGerencia
    {
        public string? Gerencia { get; set; }
        public PrazosPorGerencia PrazosPorGerencias { get; set; }
    }

    public class PrazosPorGerencia
    {
        public int TotaProcessos { get; set; }
        public int PrazoEmDia { get; set; }
        public int PrazoVencimento1Dia { get; set; }
        public int PrazoAtrasado { get; set; }
    }

    public class Prazo
    {
        public int Alta { get; set; }
        public int Media { get; set; }
        public int Baixa { get; set; }
        public int Total { get; set; }
    }
}

