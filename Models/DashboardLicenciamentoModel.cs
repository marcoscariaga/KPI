using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace KPI.Models
{
    public partial class DashboardLicenciamentoModel
    {
        public string? Licencas { get; set; }

        public int Total { get; set; }

        public int Ano { get; set; }

        public int Codigo { get; set; }

        public string? Descricao { get; set; }
        
        public int TotalLicenciados { get; set; }
    }
}
