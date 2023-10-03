using Dapper;
using KPI.Configurations;
using KPI.Models;
using Microsoft.Data.SqlClient;

namespace KPI.Repositories
{
    public class EventoRepository
    {
        public async Task<List<DashboardEventoModel>> GetEventoOrganizador(DateTime? dataEvento)
        {
            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                var sql = @"USE sisvisa
					SELECT r.codigoDaCPE AS 'CPE',
						CONVERT(DATE, r.DataDoRequerimento, 103) AS 'DataDaSolicitacao',
						r.Protocolo AS Processo,
						e.nomerequerente AS Requerente,
						CONVERT(DATE, r.DataDeInicio, 103) AS 'DataDoEvento',
						CONVERT(DATE, r.datadefim, 103) AS 'DataFimEvento',
						CASE 
							WHEN r.Situacao = 0
								THEN 'EM PREENCHIMENTO'
							WHEN r.Situacao = 1
								THEN 'EM PROCESSAMENTO'
							WHEN r.Situacao = 2
								THEN 'DEFERIDO'
							WHEN r.Situacao = 3
								THEN 'PAGAMENTO VENCIDO'
							WHEN r.Situacao = 9
								THEN 'INDEFERIDO'
							WHEN r.Situacao = 7
								THEN 'REQUERIMENTO CANCELADO'
							WHEN r.Situacao = 8
								THEN 'LICENÇA CANCELADA'
							END AS 'Status',
						e.EnderecoEvento AS 'LocalDoEvento',
						e.NomeEvento AS 'NomeDoEvento',
						CASE 
							WHEN r.Tipo = 0
								THEN 'NÃO POSSUI'
							WHEN r.Tipo = 1
								THEN 'ORGANIZADOR'
							WHEN r.Tipo = 2
								THEN 'ALIMENTOS'
							WHEN r.Tipo = 3
								THEN 'SAÚDE'
							WHEN r.Tipo = 4
								THEN 'ANIMAIS'
							WHEN r.Tipo = 5
								THEN 'OBRA'
							WHEN r.Tipo = 6
								THEN 'COZINHA DE OBRA'
							END AS 'Organizador',
						CASE 
							WHEN r.CodigoDeQuantidadeDePessoas = 1
								THEN 'Menos de 1000 pessoas/dia'
							WHEN r.CodigoDeQuantidadeDePessoas = 2
								THEN 'Entre 1000 e 5000 pessoas/dia'
							WHEN r.CodigoDeQuantidadeDePessoas = 3
								THEN 'Entre 5000 e 20.000 pessoas/dia'
							WHEN r.CodigoDeQuantidadeDePessoas = 4
								THEN 'Entre 20.000 e 50.000 pessoas/dia'
							WHEN r.CodigoDeQuantidadeDePessoas = 5
								THEN 'Acima de 50.000 pessoas/dia'
							END AS 'Público Estimado Declarado',
						E.estimativaPublico AS 'PublicoEstimadoDeclaradoCPE',
						CASE 
							WHEN r.CodigoDaArea = 1.00000
								THEN 'Até 50m2 '
							WHEN r.CodigoDaArea = 2.00000
								THEN 'Acima de 50m2 e até 100m2'
							WHEN r.CodigoDaArea = 3.00000
								THEN 'Acima de 100m2 e até 200m2 '
							WHEN r.CodigoDaArea = 4.00000
								THEN 'Acima de 200m2 e até 400m2'
							WHEN r.CodigoDaArea = 5.00000
								THEN 'Acima de 400m2 e até 800m2'
							WHEN r.CodigoDaArea = 6.00000
								THEN 'Acima de 800m2 e até 1600m2'
							WHEN r.CodigoDaArea = 7.00000
								THEN 'Acima de 1600m2'
							END AS Area,
						CONVERT(DATE, c.DT_PAGAMENTO, 103) AS 'DataPagamento',
						c.VL_PRINCIPAL AS 'ValorPagamento',
						(SELECT SUBSTRING(b.Descricao, 0, LEN(b.Descricao)+1) FROM AtividadeParaRequerimentoTransitorio b
						   WHERE b.Descricao = ART.Descricao FOR XML PATH('')
						   ) AS 'AtividadesExercidas'
					FROM RequerimentoTransitorio r
					INNER JOIN Evento e ON e.CPE = r.CodigoDaCPE
					INNER JOIN AtividadeDoRequerimentoTransitorio ON AtividadeDoRequerimentoTransitorio.IdDoRequerimentoTransitorio = r.Id
					INNER JOIN AtividadeParaRequerimentoTransitorio ART ON ART.Codigo = AtividadeDoRequerimentoTransitorio.CodigoDaAtividadeDoRequerimentoTransitorio
					LEFT JOIN CobrancaSisvisa c ON c.ID_REQUERIMENTO = r.id
					WHERE r.Tipo = 1
						AND r.Situacao NOT IN (0)
						AND SUBSTRING(CONVERT(VARCHAR, e.DataEvento, 101), 7, 10) = YEAR(GETDATE())
						AND (
							CONVERT(DATE, e.DataInicioEvento, 103) BETWEEN CONVERT(DATE, GETDATE(), 103)
								AND CONVERT(DATE, GETDATE() + 3, 103)
							OR CONVERT(DATE, e.DataFimEvento, 103) > CONVERT(DATE, GETDATE() + 3, 103)
							AND CONVERT(DATE, e.DataInicioEvento, 103) < CONVERT(DATE, GETDATE(), 103)
							)
					ORDER BY E.DataInicioEvento";

                var result = await connection.QueryAsync<DashboardEventoModel>(sql, new { dataEvento });
                return result.ToList();
            }
        }
    }
}