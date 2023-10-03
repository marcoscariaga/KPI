using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace KPI.Models
{
    public partial class DashboardEventoModel
    {
        public int CPE { get; set; }

        public DateTime DataDaSolicitacao { get; set; }

        public string? Processo { get; set; }

        public string? Requerente { get; set; }

        public DateTime DataDoEvento { get; set; }

        public DateTime DataFimEvento { get; set; }

        public string? Status { get; set; }

        public string? LocalDoEvento { get; set; }

        public string? NomeDoEvento { get; set; }

        public string? Organizador { get; set; }

        public string? PublicoEstimadoDeclaradoCPE { get; set; }

        public string? Area { get; set; }

        public DateTime DataPagamento { get; set; }

        public double ValorPagamento { get; set; }

        public string? AtividadesExercidas { get; set; }

        public DateTime DataFiltro { get; set; }
    }
}

