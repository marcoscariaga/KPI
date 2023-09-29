using Dapper;
using KPI.Configurations;
using KPI.Models;
using Microsoft.Data.SqlClient;

namespace KPI.Repositories
{
    public class LicenciamentoRepository
    {
        public async Task<List<DashboardLicenciamentoModel>> GetTotalLicenciados(int ano, List<int> codigoAtividade, int idSegmento, bool licenciada)
        {
            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                var sql = @"SELECT A.Codigo, A.Descricao, COUNT(AE.EstabelecimentoId) AS 'TOTAL LICENCIADOS'
                            FROM Estabelecimento E
                            JOIN AtividadesDoEstabelecimento AE ON AE.EstabelecimentoId = E.Id
                            JOIN Atividade A ON A.Codigo = AE.Codigo
                            JOIN HistoricoDeLicenca H ON H.EstabelecimentoId = E.Id AND H.NumeroDaLicenca = E.NumeroLicenca
                            WHERE A.SegmentoId = 5
                            AND A.Grupo = 2
                            AND AE.Licenciada = 1
                            AND A.Codigo IN(229067, 225746, 225053, 225738)
                            AND E.Ativo<> 0
                            AND E.SituacaoDoAlvara = '01 - ATIVO'
                            AND YEAR(H.DataDeValidade) = '2024'
                            GROUP BY A.Codigo, A.Descricao";

                var result = await connection.QueryAsync<DashboardLicenciamentoModel>(sql);
                return result.ToList();
            }
        }

        public async Task<List<DashboardLicenciamentoModel>> GetTotalLicencasDeferidas()
        {
            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                var sql = @"select 'Deferidas' as 'Licenças', count(req.id) as 'Total' from RequerimentoAutodeclaracao req
                            where year(req.DataInicio) = 2023
                            and req.situacaoId = 7 
                            union all
                            select 'Veículos' as 'Licenças', count(req.id) as 'Total' from RequerimentoAdministrativo req
                            where year(req.DataDeEnvio) = 2023
                            and req.VeiculoId is not null
                            and  req.situacaoId = 7 ";

                var result = await connection.QueryAsync<DashboardLicenciamentoModel>(sql);
                return result.ToList();
            }
        }
    }
}
