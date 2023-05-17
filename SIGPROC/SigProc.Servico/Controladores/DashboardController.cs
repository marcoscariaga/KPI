using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos.ModeloSaida;
using SigProc.Dominio.Entidades;

namespace SigProc.Servico.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IProcessoServico _processoServico;
        private readonly IProcessoTramitacaoServico _tramitacaoServico;
        private readonly IGerenciaUsuarioServico _gerenciaUsuarioServico;
        private readonly IGerenciaServico _gerenciaServico;

        public DashboardController(IProcessoServico processoServico, IProcessoTramitacaoServico tramitacaoServico, IGerenciaUsuarioServico gerenciaUsuarioServico, IGerenciaServico gerenciaServico)
        {
            _processoServico = processoServico;
            _tramitacaoServico = tramitacaoServico;
            _gerenciaUsuarioServico = gerenciaUsuarioServico;
            _gerenciaServico = gerenciaServico;
        }

        [HttpGet("TotalProcessosPrazos/{idUsuario}")]
        public IActionResult TotalProcessosPrazos(int idUsuario)
        {
            try
            {
                var tramitacoes = _tramitacaoServico.BuscarUltimaTramitacaoPorUsuarioGerencial(idUsuario);

                var model = new PrazosPorGerencia()
                {
                    TotalProcessos = tramitacoes.Count(),
                    PrazoEmDia = tramitacoes.Count(x => x.TempoPrazo > 1),
                    PrazoVencimento1Dia = tramitacoes.Count(x => x.TempoPrazo >= 0 && x.TempoPrazo <= 1),
                    PrazoAtrasado = tramitacoes.Count(x => x.TempoPrazo < 0),
                };
                return StatusCode(200, model);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao buscar gerência!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar gerencia!" });
            }
        }

        [HttpGet("TotalProcessosPorGerencia/{idUsuario}")]
        public IActionResult TotalProcessosPorGerencia(int idUsuario)
        {
            try
            {
                var tramitacoesPorGerencia = _tramitacaoServico.ListarAtivos().Join(_gerenciaServico.ListarTudo(), p => p.IdOrgaoDestino, ip2 => ip2.Id, (p, ip2) => new { p, ip2 })
                                                                                 .Where(x => x.p.DataEnvio == null)
                                                                                 .OrderByDescending(x => x.p.Sequencia)
                                                                                 .ToList();
                var listagemTramitacao = new List<TotalProcessoPorGerencia>();
                var quantidadePrazoEmDia = 0;
                var quantidadePrazoVencimento1Dia = 0;
                var quantidadePrazoAtrasado = 0;
                var quantidadeTotaProcessos = 0;

                if (tramitacoesPorGerencia.Count() != 0)
                {
                    var contagem = new PrazosPorGerencia()
                    {
                        TotalProcessos = tramitacoesPorGerencia.Count(),
                        PrazoEmDia = tramitacoesPorGerencia.Count(x => x.p.TempoPrazo > 1),
                        PrazoVencimento1Dia = tramitacoesPorGerencia.Count(x => x.p.TempoPrazo >= 0 && x.p.TempoPrazo <= 1),
                        PrazoAtrasado = tramitacoesPorGerencia.Count(x => x.p.TempoPrazo < 0),
                    };

                    var model = new TotalProcessoPorGerencia();
                    model.Gerencia = tramitacoesPorGerencia[0].p.GerenciaDestino.Sigla;
                    model.PrazosPorGerencias = contagem;

                    quantidadePrazoEmDia += model.PrazosPorGerencias.PrazoEmDia;
                    quantidadePrazoVencimento1Dia += model.PrazosPorGerencias.PrazoVencimento1Dia;
                    quantidadePrazoAtrasado += model.PrazosPorGerencias.PrazoAtrasado;
                    quantidadeTotaProcessos += model.PrazosPorGerencias.TotalProcessos;

                    listagemTramitacao.Add(model);
                }

                var contagens = new PrazosPorGerencia()
                {
                    TotalProcessos = quantidadeTotaProcessos,
                    PrazoEmDia = quantidadePrazoEmDia,
                    PrazoVencimento1Dia = quantidadePrazoVencimento1Dia,
                    PrazoAtrasado = quantidadePrazoAtrasado,
                };
                var totalProcessos = new TotalProcessoPorGerencia();
                totalProcessos.Gerencia = "Total";
                totalProcessos.PrazosPorGerencias = contagens;
                listagemTramitacao.Add(totalProcessos);

                return StatusCode(200, listagemTramitacao);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao buscar gerência!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar gerencia!" });
            }
        }

        [HttpGet("TotalPrioridadePorGerencia/{idUsuario}")]
        public IActionResult TotalProPrioridadePorGerencia(int idUsuario)
        {
            try
            {
                var tramitacoesPorGerencia = _tramitacaoServico.ListarAtivos().Join(_gerenciaServico.ListarTudo(), p => p.IdOrgaoDestino, ip2 => ip2.Id, (p, ip2) => new { p, ip2 })
                                                                           .Where(x => x.p.DataEnvio == null)
                                                                           .OrderByDescending(x => x.p.Sequencia)
                                                                           .ToList();
                var listagemTramitacao = new List<TotalDashboardModelo>();

                foreach (var tramitacao in tramitacoesPorGerencia)
                {
                    if (tramitacao.p.Processo.Prioridade == "alta")
                    {
                        var model = new TotalDashboardModelo();
                        model.Prioridade = "Alta";
                        model.Gerencia = tramitacao.p.GerenciaDestino.Sigla;
                        model.Quantidade += 1;

                        listagemTramitacao.Add(model);
                    }
                    if (tramitacao.p.Processo.Prioridade == "media")
                    {
                        var model = new TotalDashboardModelo();
                        model.Prioridade = "Média";
                        model.Gerencia = tramitacao.p.GerenciaDestino.Sigla;
                        model.Quantidade += 1;

                        listagemTramitacao.Add(model);
                    }
                    if (tramitacao.p.Processo.Prioridade == "baixa")
                    {
                        var model = new TotalDashboardModelo();
                        model.Prioridade = "Baixa";
                        model.Gerencia = tramitacao.p.GerenciaDestino.Sigla;
                        model.Quantidade += 1;

                        listagemTramitacao.Add(model);
                    }
                }

                return StatusCode(200, listagemTramitacao);

            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao buscar gerência!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar gerencia!" });
            }
        }
        [HttpGet("TotalPrioridade/{idUsuario}")]
        public IActionResult TotalProPrioridade(int idUsuario)
        {
            try
            {
                var listagemTramitacao = new List<TotalDashboardModelo>();
                var quantidadeAlta = 0;
                var quantidadeMedia = 0;
                var quantidadeBaixa = 0;


                var tramitacoesPorGerencia = _tramitacaoServico.ListarAtivos().Where(pt => pt.DataEnvio == null)
                                                          .GroupBy(pt => pt.IdProcesso)
                                                          .Select(g => g.OrderByDescending(pt => pt.DataTramitacao)
                                                          .FirstOrDefault())
                                                          .ToList();

                foreach (var tramitacao in tramitacoesPorGerencia)
                {
                    if (tramitacao.Processo.Prioridade == "alta")
                    {
                        quantidadeAlta += 1;
                    }
                    if (tramitacao.Processo.Prioridade == "media")
                    {
                        quantidadeMedia += 1;
                    }
                    if (tramitacao.Processo.Prioridade == "baixa")
                    {
                        quantidadeBaixa += 1;
                    }
                }

                var model = new Prazo()
                {
                    Alta = quantidadeAlta,
                    Media = quantidadeMedia,
                    Baixa = quantidadeBaixa,
                    Total = quantidadeAlta + quantidadeMedia + quantidadeBaixa,
                };


                return StatusCode(200, model);

            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao buscar gerência!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar gerencia!" });
            }
        }
    }
}



