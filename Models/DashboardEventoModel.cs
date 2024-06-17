using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace KPI.Models
{
    public partial class DashboardEventoModel
    {
        public int CPE { get; set; }

        public DateTime DataDaSolicitacao { get; set; }

        public string? Processo { get; set; }

        public string? Requerente { get; set; }

        public string? RazaoSocial { get; set; }

        public DateTime DataDoEvento { get; set; }

        public DateTime DataFimEvento { get; set; }

        public string? Status { get; set; }

        public string? EnderecoEmpresa { get; set; }

        public string? NomeDoEvento { get; set; }

        public string? Organizador { get; set; }

        public string? Fornecedor { get; set; }

        public string? PublicoEstimadoDeclarado { get; set; }

        public string? PublicoEstimadoDeclaradoCPE { get; set; }

        public string? Area { get; set; }

        public DateTime DataPagamento { get; set; }

        public double ValorPagamento { get; set; }

        public string? AtividadesExercidas { get; set; }

        public DateTime DataFiltro { get; set; }

		public string? Email { get; set; }

        public string? CNPJ { get; set;}

        public string? CPF { get; set; }

        public string? InscricaoMunicipal { get; set; }

        public string? AlvaraLiberado { get; set; }

        public string? EnderecoEvento { get; set; }

        public string? DescricaoEvento { get; set; }

        public DateTime DataInicioEvento { get; set; }

        public DateTime DataInicioMontagem { get; set; }

        public DateTime DataFimMontagem { get; set; }

        public string? AlteracaoLocal { get; set; }

        public string? EstimativaPublico { get; set; }

        public string? ManipulacaoAlimento { get; set; }
    }
}

