using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos.ModeloSaida;
using SigProc.Aplicacao.Servicos;
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
            //var soma = PrazoEmDia + PrazoVencimento1Dia;
            try
            {
                var tramitacoes = _tramitacaoServico.BuscarUltimaTramitacaoPorUsuarioGerencial(idUsuario);
                var model = new PrazosPorGerencia()
                {

                    TotalProcessos = tramitacoes.Count(),
                    PrazoEmDia = tramitacoes.Count(x => x.TempoPrazo > 1) + tramitacoes.Count(x => x.TempoPrazo >= 0 && x.TempoPrazo <= 1),
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

        //Codigo novo mostra no Dashboard todos os processos agrupados por gerencia
        [HttpGet("TotalProcessosPorGerencia/{idUsuario}")]
        public IActionResult TotalProcessosPorGerencia(int idUsuario)
        {
            try
            {
                var tramitacoesPorGerencia = _tramitacaoServico.ListarAtivos().Join(_gerenciaServico.ListarTudo(), p => p.IdOrgaoDestino,
                    ip2 => ip2.Id, (p, ip2) => new { p, ip2 })
                    .Where(x => x.p.DataEnvio == null)
                    .OrderByDescending(x => x.p.Sequencia)
                    .ToList();
                var listagemTramitacao = tramitacoesPorGerencia
                    .GroupBy(x => x.p.GerenciaDestino.Sigla) // Agrupa por gerência
                    .Select(g => new TotalProcessoPorGerencia
                    {
                        Gerencia = g.Key,
                        PrazosPorGerencias = new PrazosPorGerencia
                        {
                            TotalProcessos = g.Count(),
                            PrazoEmDia = g.Count(x => x.p.TempoPrazo > 1),
                            PrazoVencimento1Dia = g.Count(x => x.p.TempoPrazo >= 0 && x.p.TempoPrazo <= 1),
                            PrazoAtrasado = g.Count(x => x.p.TempoPrazo < 0)
                        }
                    })
                    .ToList();
                // Adiciona a contagem total de processos de todas as gerências
                var contagens = new PrazosPorGerencia
                {
                    TotalProcessos = listagemTramitacao.Sum(x => x.PrazosPorGerencias.TotalProcessos),
                    PrazoEmDia = listagemTramitacao.Sum(x => x.PrazosPorGerencias.PrazoEmDia),
                    PrazoVencimento1Dia = listagemTramitacao.Sum(x => x.PrazosPorGerencias.PrazoVencimento1Dia),
                    PrazoAtrasado = listagemTramitacao.Sum(x => x.PrazosPorGerencias.PrazoAtrasado)
                };
                var totalProcessos = new TotalProcessoPorGerencia
                {
                    Gerencia = "Total",
                    PrazosPorGerencias = contagens
                };
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

        //Codigo antigo mostra todos os processos em geral 
        //[HttpGet("TotalProcessosPorGerencia/{idUsuario}")]
        //public IActionResult TotalProcessosPorGerencia(int idUsuario)
        //{
        //    try
        //    {
        //        var tramitacoesPorGerencia = _tramitacaoServico.ListarAtivos().Join(_gerenciaServico.ListarTudo(), p => p.IdOrgaoDestino, ip2 => ip2.Id, (p, ip2) => new { p, ip2 })
        //            .Where(x => x.p.DataEnvio == null)
        //            .OrderByDescending(x => x.p.Sequencia)
        //            .ToList();
        //        var listagemTramitacao = new List<TotalProcessoPorGerencia>();
        //        var quantidadePrazoEmDia = 0;
        //        var quantidadePrazoVencimento1Dia = 0;
        //        var quantidadePrazoAtrasado = 0;
        //        var quantidadeTotaProcessos = 0;
        //        if (tramitacoesPorGerencia.Count() != 0)
        //        {
        //            var contagem = new PrazosPorGerencia()
        //            {
        //                TotalProcessos = tramitacoesPorGerencia.Count(),
        //                PrazoEmDia = tramitacoesPorGerencia.Count(x => x.p.TempoPrazo > 1),
        //                PrazoVencimento1Dia = tramitacoesPorGerencia.Count(x => x.p.TempoPrazo >= 0 && x.p.TempoPrazo <= 1),
        //                PrazoAtrasado = tramitacoesPorGerencia.Count(x => x.p.TempoPrazo < 0),
        //            };
        //            var model = new TotalProcessoPorGerencia();
        //            model.Gerencia = tramitacoesPorGerencia[0].p.GerenciaDestino.Sigla;
        //            model.PrazosPorGerencias = contagem;
        //            quantidadePrazoEmDia += model.PrazosPorGerencias.PrazoEmDia;
        //            quantidadePrazoVencimento1Dia += model.PrazosPorGerencias.PrazoVencimento1Dia;
        //            quantidadePrazoAtrasado += model.PrazosPorGerencias.PrazoAtrasado;
        //            quantidadeTotaProcessos += model.PrazosPorGerencias.TotalProcessos;
        //            listagemTramitacao.Add(model);
        //        }
        //        var contagens = new PrazosPorGerencia()
        //        {
        //            TotalProcessos = quantidadeTotaProcessos,
        //            PrazoEmDia = quantidadePrazoEmDia,
        //            PrazoVencimento1Dia = quantidadePrazoVencimento1Dia,
        //            PrazoAtrasado = quantidadePrazoAtrasado,
        //        };
        //        var totalProcessos = new TotalProcessoPorGerencia();
        //        totalProcessos.Gerencia = "Total";
        //        totalProcessos.PrazosPorGerencias = contagens;
        //        listagemTramitacao.Add(totalProcessos);
        //        return StatusCode(200, listagemTramitacao);
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        return StatusCode(400, new { ex.Message, mensagem = "Erro ao buscar gerência!" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar gerencia!" });
        //    }
        //}


        //Mostra no Dashboard todas Prioridades agrupadas por Gerencia
        [HttpGet("TotalPrioridadePorGerencia/{idUsuario}")]
        public IActionResult TotalProPrioridadePorGerencia(int idUsuario)
        {
            try
            {
                var gerencias = _gerenciaServico.ListarTudo().Select(g => g.Sigla).ToList();
                var tramitacoesPorGerencia = _tramitacaoServico.ListarAtivos()
                    .Join(_gerenciaServico.ListarTudo(), p => p.IdOrgaoDestino, ip2 => ip2.Id, (p, ip2) => new { p, ip2 })
                    .Where(x => x.p.DataEnvio == null)
                    .OrderByDescending(x => x.p.Sequencia)
                    .ToList();
                var listagemTramitacao = new List<TotalDashboardModelo>();
                foreach (var gerencia in gerencias)
                {
                    var altaCount = 0;
                    var mediaCount = 0;
                    var baixaCount = 0;
                    foreach (var tramitacao in tramitacoesPorGerencia.Where(x => x.p.GerenciaDestino.Sigla == gerencia))
                    {
                        if (tramitacao.p.Processo.Prioridade == "alta")
                        {
                            altaCount++;
                        }
                        else if (tramitacao.p.Processo.Prioridade == "media")
                        {
                            mediaCount++;
                        }
                        else if (tramitacao.p.Processo.Prioridade == "baixa")
                        {
                            baixaCount++;
                        }
                    }
                    if (altaCount > 0)
                    {
                        var altaModel = new TotalDashboardModelo();
                        altaModel.Prioridade = "Alta";
                        altaModel.Gerencia = gerencia;
                        altaModel.Quantidade = altaCount;
                        listagemTramitacao.Add(altaModel);
                    }
                    if (mediaCount > 0)
                    {
                        var mediaModel = new TotalDashboardModelo();
                        mediaModel.Prioridade = "Média";
                        mediaModel.Gerencia = gerencia;
                        mediaModel.Quantidade = mediaCount;
                        listagemTramitacao.Add(mediaModel);
                    }
                    if (baixaCount > 0)
                    {
                        var baixaModel = new TotalDashboardModelo();
                        baixaModel.Prioridade = "Baixa";
                        baixaModel.Gerencia = gerencia;
                        baixaModel.Quantidade = baixaCount;
                        listagemTramitacao.Add(baixaModel);
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

        //Prioridade por gerencia código antigo mostra todas as prioridades
        //[HttpGet("TotalPrioridadePorGerencia/{idUsuario}")]
        //public IActionResult TotalProPrioridadePorGerencia(int idUsuario)
        //{
        //    try
        //    {
        //        var tramitacoesPorGerencia = _tramitacaoServico.ListarAtivos().Join(_gerenciaServico.ListarTudo(), p => p.IdOrgaoDestino, ip2 => ip2.Id, (p, ip2) => new { p, ip2 })
        //            .Where(x => x.p.DataEnvio == null)
        //            .OrderByDescending(x => x.p.Sequencia)
        //            .ToList();
        //        var listagemTramitacao = new List<TotalDashboardModelo>();
        //        foreach (var tramitacao in tramitacoesPorGerencia)
        //        {
        //            if (tramitacao.p.Processo.Prioridade == "alta")
        //            {
        //                var model = new TotalDashboardModelo();
        //                model.Prioridade = "Alta";
        //                model.Gerencia = tramitacao.p.GerenciaDestino.Sigla;
        //                model.Quantidade += 1;
        //                listagemTramitacao.Add(model);
        //            }
        //            if (tramitacao.p.Processo.Prioridade == "media")
        //            {
        //                var model = new TotalDashboardModelo();
        //                model.Prioridade = "Média";
        //                model.Gerencia = tramitacao.p.GerenciaDestino.Sigla;
        //                model.Quantidade += 1;
        //                listagemTramitacao.Add(model);
        //            }
        //            if (tramitacao.p.Processo.Prioridade == "baixa")
        //            {
        //                var model = new TotalDashboardModelo();
        //                model.Prioridade = "Baixa";
        //                model.Gerencia = tramitacao.p.GerenciaDestino.Sigla;
        //                model.Quantidade += 1;
        //                listagemTramitacao.Add(model);
        //            }
        //        }
        //        return StatusCode(200, listagemTramitacao);
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        return StatusCode(400, new { ex.Message, mensagem = "Erro ao buscar gerência!" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar gerencia!" });
        //    }
        //}
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



