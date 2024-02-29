using Dapper;
using KPI.Configurations;
using KPI.Models;
using Microsoft.Data.SqlClient;

namespace KPI.Repositories
{
    public class LicenciamentoRepository
    {
        public async Task<List<DashboardLicenciamentoModel>> GetTotalLicenciados(int ano, int[] codigoAtividade, int idSegmento, int licenciada)
        {
            string codigoAtividadeString = string.Join(",", codigoAtividade);

            var sql = @"SELECT A.Codigo, A.Descricao, COUNT(AE.EstabelecimentoId) AS 'TotalLicenciados'
                        FROM Estabelecimento E
                        JOIN AtividadesDoEstabelecimento AE ON AE.EstabelecimentoId = E.Id
                        JOIN Atividade A ON A.Codigo = AE.Codigo
                        JOIN HistoricoDeLicenca H ON H.EstabelecimentoId = E.Id AND H.NumeroDaLicenca = E.NumeroLicenca
                        WHERE A.SegmentoId = @idSegmento
                        AND A.Grupo = 2
                        AND AE.Licenciada = @licenciada
                        AND A.Codigo IN (" + codigoAtividadeString + @")
                        AND E.Ativo <> 0
                        AND E.SituacaoDoAlvara = '01 - ATIVO'
                        AND YEAR(H.DataDeValidade) = @ano
                        GROUP BY A.Codigo, A.Descricao";

            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                var result = await connection.QueryAsync<DashboardLicenciamentoModel>(sql, new { idSegmento, codigoAtividade, licenciada, ano });
                return result.ToList();
            }
        }


        public async Task<List<DashboardLicenciamentoModel>> GetTotalLicencasDeferidas(int ano, int situacao)
        {
            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                var sql = @"select 'Deferidas' as 'Licencas', count(req.id) as 'Total' from RequerimentoAutodeclaracao req
                            where year(req.DataInicio) = @ano
                            and req.situacaoId = @situacao
                            union all
                            select cast('Veículos' as varchar) as 'Licencas', count(req.id) as 'Total' from RequerimentoAdministrativo req
                            where year(req.DataDeEnvio) = @ano
                            and req.VeiculoId is not null
                            and  req.situacaoId = @situacao
                            union all 
                            SELECT Licencas, SUM(Valor) FROM (
	                        select 'Total' as 'Licencas', count(req.id) as 'Valor' from RequerimentoAutodeclaracao req
	                        where year(req.DataInicio) = 2024
	                        and req.situacaoId = 7
	                        union all
	                        select 'Total' as 'Licencas', count(req.id) as 'Valor' from RequerimentoAdministrativo req
	                        where year(req.DataDeEnvio) = 2024
	                        and req.VeiculoId is not null
	                        and  req.situacaoId = 7) A
	                        group by Licencas";

                var result = await connection.QueryAsync<DashboardLicenciamentoModel>(sql, new { ano, situacao });
                return result.ToList();
            }
        }
    }
}
