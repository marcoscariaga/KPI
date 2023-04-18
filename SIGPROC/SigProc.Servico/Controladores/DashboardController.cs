using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public DashboardController(IProcessoServico processoServico, IProcessoTramitacaoServico tramitacaoServico, IGerenciaUsuarioServico gerenciaUsuarioServico)
        {
            _processoServico = processoServico;
            _tramitacaoServico = tramitacaoServico;
            _gerenciaUsuarioServico = gerenciaUsuarioServico;
        }

        [HttpGet("TotalProcessosPrazos/{idUsuario}")]
        public IActionResult TotalProcessosPrazos(int idUsuario)
        {
            try
            {
                var tramitacoes = _tramitacaoServico.BuscarUltimaTramitacaoPorUsuarioGerencial(idUsuario);

                var model = new Prazos()
                {
                    TotaProcessos = tramitacoes.Count(),
                    PrazoEmDia = tramitacoes.Count(x => x.TempoPrazo > 0),
                    PrazoVencimento1Dia = tramitacoes.Count(x => x.TempoPrazo == 1),
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
                var gerencias = _gerenciaUsuarioServico.ListarAtivos().Where(x => x.IdUsuarioGerencia == idUsuario).ToList();
                var listagemTramitacao = new List<TotalDashboardModelo>();
                var quantidadeProcessos = 0;
                foreach (var gerencia in gerencias)
                {
                    var tramitacoesPorGerencia = _tramitacaoServico.ListarAtivos().Where(pt => pt.IdOrgaoDestino == gerencia.IdGerencia)
                                                 .GroupBy(pt => pt.IdProcesso)
                                                 .Select(g => g.OrderByDescending(pt => pt.DataTramitacao)
                                                 .FirstOrDefault())
                                                 .ToList();

                    foreach (var tramitacao in tramitacoesPorGerencia)
                    {
                        var model = new TotalDashboardModelo();
                        model.Gerencia = tramitacao.GerenciaDestino.Sigla;
                        model.Quantidade = _tramitacaoServico.ListarAtivos().Where(x => x.DataEnvio.Equals(null) && x.IdOrgaoDestino.Equals(tramitacao.IdOrgaoDestino)).Count();
                        listagemTramitacao.Add(model);
                        quantidadeProcessos += model.Quantidade;
                    }

                }
                var totalProcessos = new TotalDashboardModelo();
                totalProcessos.Gerencia = "Total";
                totalProcessos.Quantidade = quantidadeProcessos;
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

        [HttpGet("TotalProPrioridade/{idUsuario}")]
        public IActionResult TotalProPrioridade(int idUsuario)
        {
            try
            {
                var gerencias = _gerenciaUsuarioServico.ListarAtivos().Where(x => x.IdUsuarioGerencia == idUsuario).ToList();
                var listagemTramitacao = new List<TotalDashboardModelo>();
                var quantidadeProcessos = 0;
       
                foreach (var gerencia in gerencias)
                {
                    var tramitacoesPorGerencia = _tramitacaoServico.ListarAtivos().Where(pt => pt.IdOrgaoDestino == gerencia.IdGerencia)
                                                                 .GroupBy(pt => pt.IdProcesso)
                                                                 .Select(g => g.OrderByDescending(pt => pt.DataTramitacao)
                                                                 .FirstOrDefault())
                                                                 .ToList();

                    foreach (var tramitacao in tramitacoesPorGerencia)
                    {
                        if (tramitacao.Processo.Prioridade == "alta")
                        {
                            var model = new TotalDashboardModelo();
                            model.Prioridade = "Alta";
                            model.Gerencia = tramitacao.GerenciaDestino.Sigla;
                            model.Quantidade += 1;

                            listagemTramitacao.Add(model);
                            quantidadeProcessos += model.Quantidade;
                        }
                        if (tramitacao.Processo.Prioridade == "media")
                        {
                            var model = new TotalDashboardModelo();
                            model.Prioridade = "Média";
                            model.Gerencia = tramitacao.GerenciaDestino.Sigla;
                            model.Quantidade += 1;

                            listagemTramitacao.Add(model);
                            quantidadeProcessos += model.Quantidade;
                        }
                        if (tramitacao.Processo.Prioridade == "baixo")
                        {
                            var model = new TotalDashboardModelo();
                            model.Prioridade = "Baixa";
                            model.Gerencia = tramitacao.GerenciaDestino.Sigla;
                            model.Quantidade += 1;

                            listagemTramitacao.Add(model);
                            quantidadeProcessos += model.Quantidade;
                        }
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
    }
}

public class Prazos
{
    public int TotaProcessos { get; set; }
    public int PrazoEmDia { get; set; }
    public int PrazoVencimento1Dia { get; set; }
    public int PrazoAtrasado { get; set; }
}

