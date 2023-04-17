using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SigProc.Aplicacao.Contratos;
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

        [HttpGet("TotalProcessos/{idUsuario}")]
        public IActionResult TotalProcessos(int idUsuario)
        {
            try
            {
                var gerencia = _tramitacaoServico.BuscarUltimaTramitacaoPorUsuarioGerencial(idUsuario).Count();

                return StatusCode(200, gerencia);
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

        [HttpGet("TotalProcessosEmAtraso/{idUsuario}")]
        public IActionResult TotalProcessosEmAtraso(int idUsuario)
        {
            try
            {
                var gerencia = _tramitacaoServico.BuscarUltimaTramitacaoPorUsuarioGerencial(idUsuario).Where(x => x.TempoPrazo < 0).Count();

                return StatusCode(200, gerencia);
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

        [HttpGet("TotalProcessos1DiaDoPrazo/{idUsuario}")]
        public IActionResult TotalProcessos1DiaDoPrazo(int idUsuario)
        {
            try
            {
                var gerencia = _tramitacaoServico.BuscarUltimaTramitacaoPorUsuarioGerencial(idUsuario).Where(x => x.TempoPrazo >= 0 && x.TempoPrazo == 1).Count();

                return StatusCode(200, gerencia);
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

        [HttpGet("TotalProcessosEmDia/{idUsuario}")]
        public IActionResult TotalProcessosEmDia(int idUsuario)
        {
            try
            {
                var gerencia = _tramitacaoServico.BuscarUltimaTramitacaoPorUsuarioGerencial(idUsuario).Where(x => x.TempoPrazo > 0).Count();

                return StatusCode(200, gerencia);
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
                var listagemTramitacao = new List<Dados>();
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
                        var model = new Dados();
                        model.Gerencia = tramitacao.GerenciaDestino.Sigla;
                        model.Quantidade = _tramitacaoServico.ListarAtivos().Where(x => x.DataEnvio.Equals(null) && x.IdOrgaoDestino.Equals(tramitacao.IdOrgaoDestino)).Count();
                        listagemTramitacao.Add(model);
                        quantidadeProcessos += model.Quantidade;
                    }

                }
                var totalProcessos = new Dados();
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
                var listagemTramitacao = new List<DadosPrioridade>();
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
                            var model = new DadosPrioridade();
                            model.Prioridade = "Alta";
                            model.Gerencia = tramitacao.GerenciaDestino.Sigla;
                            model.Quantidade = _tramitacaoServico.ListarAtivos().Where(x => x.DataEnvio.Equals(null) && x.IdOrgaoDestino.Equals(tramitacao.IdOrgaoDestino)).Count();
                            if (model.Quantidade != 0)
                            {
                                listagemTramitacao.Add(model);
                                quantidadeProcessos += model.Quantidade;
                            }
                        }
                        if (tramitacao.Processo.Prioridade == "media")
                        {
                            var model = new DadosPrioridade();
                            model.Prioridade = "Média";
                            model.Gerencia = tramitacao.GerenciaDestino.Sigla;
                            model.Quantidade = _tramitacaoServico.ListarAtivos().Where(x => x.DataEnvio.Equals(null) && x.IdOrgaoDestino.Equals(tramitacao.IdOrgaoDestino)).Count();
                            if (model.Quantidade != 0)
                            {
                                listagemTramitacao.Add(model);
                                quantidadeProcessos += model.Quantidade;
                            }
                        }
                        if (tramitacao.Processo.Prioridade == "baixo")
                        {
                            var model = new DadosPrioridade();
                            model.Prioridade = "Baixa";
                            model.Gerencia = tramitacao.GerenciaDestino.Sigla;
                            model.Quantidade = _tramitacaoServico.ListarAtivos().Where(x => x.DataEnvio.Equals(null) && x.IdOrgaoDestino.Equals(tramitacao.IdOrgaoDestino)).Count();
                            if (model.Quantidade != 0)
                            {
                                listagemTramitacao.Add(model);
                                quantidadeProcessos += model.Quantidade;
                            }
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

public class Dados
{
    public string Gerencia { get; set; }
    public int Quantidade { get; set; }
}

public class DadosPrioridade
{
    public string Prioridade { get; set; }
    public string Gerencia { get; set; }
    public int Quantidade { get; set; }
}
