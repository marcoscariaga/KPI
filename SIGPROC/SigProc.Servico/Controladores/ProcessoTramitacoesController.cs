using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos;
using SigProc.Aplicacao.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Servico.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessoTramitacoesController : ControllerBase
    {
        private readonly IProcessoTramitacaoServico _processoTramitacaoServico;
        private IMapper _mapper;
        private readonly IGerenciaPrazoServico _gerenciaPrazoServico;
        public ProcessoTramitacoesController(IProcessoTramitacaoServico processoTramitacaoServico, IMapper mapper, IGerenciaPrazoServico gerenciaPrazoServico)
        {
            _processoTramitacaoServico = processoTramitacaoServico;
            _mapper = mapper;
            _gerenciaPrazoServico = gerenciaPrazoServico;
        }
        [HttpGet("BuscarPorID/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var processoTramitacao = _processoTramitacaoServico.RetornaPorId(id);
                if (processoTramitacao == null)
                    return NoContent();

                return StatusCode(200, processoTramitacao);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao buscar tramitacao!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar tramitacao!" });
            }
        }

        [HttpGet("BuscarUltimaTramitacaoPorNumeroProcesso/{numeroProcesso}")]
        public IActionResult BuscarUltimaTramitacaoPorNumeroProcesso(string numeroProcesso)
        {
            try
            {
                var processoTramitacao = _processoTramitacaoServico.BuscarUltimaTramitacaoPorNumeroProcesso(numeroProcesso);
                if (processoTramitacao == null)
                    return NoContent();

                return StatusCode(200, processoTramitacao);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = $"Erro ao buscar tramitacao!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar tramitacao!" });
            }
        }
        [HttpGet("BuscarTramitacoesPorNumeroProcesso/{numeroProcesso}")]
        public IActionResult BuscarTramitacoesPorNumeroProcesso(string numeroProcesso)
        {
            try
            {
                var processoTramitacao = _processoTramitacaoServico.BuscarTramitacoesPorNumeroProcesso(numeroProcesso);
                if (processoTramitacao == null)
                    return NoContent();

                return StatusCode(200, processoTramitacao);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = $"Erro ao buscar tramitacao!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar tramitacao!" });
            }
        }
        [HttpGet("BuscarUltimaTramitacaoPorIdGerenciaAtual/{idGerencia}")]
        public IActionResult BuscarUltimaTramitacaoPorIdGerenciaAtual(int idGerencia)
        {
            try
            {
                var processoTramitacao = _processoTramitacaoServico.BuscarUltimaTramitacaoPorIdGerenciaAtual(idGerencia);
                if (processoTramitacao == null)
                    return NoContent();

                return StatusCode(200, processoTramitacao);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = $"Erro ao buscar tramitacao!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar tramitacao!" });
            }
        }
        [HttpGet("BuscarUltimaTramitacaoPorUsuarioGerencia/{idUsuario}")]
        public IActionResult BuscarUltimaTramitacaoPorUsuarioGerencial(int idUsuario)
        {
            try
            {
                var processoTramitacao = _processoTramitacaoServico.BuscarUltimaTramitacaoPorUsuarioGerencial(idUsuario);
                if (processoTramitacao == null)
                    return NoContent();

                return StatusCode(200, processoTramitacao);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = $"Erro ao buscar tramitacao!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar tramitacao!" });
            }
        }
        [HttpGet("AtualizaTramitacoes/{numeroProcesso}")]
        public IActionResult AtualizaTramitacoes(string numeroProcesso)
        {
            try
            {
                var processoTramitacao = _processoTramitacaoServico.BuscarTramitacoesPorNumeroProcesso(numeroProcesso).FirstOrDefault();


                return StatusCode(200, _processoTramitacaoServico.AtualizaTramitacao(processoTramitacao)); 
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = $"Erro ao buscar tramitacao!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar tramitacao!" });
            }
        }

        //Inicio metodo UltimaEtapaProcesso

        [HttpGet("UltimaEtapaProcesso")]
        public IActionResult UltimaEtapaProcesso(TramitacaoEtapaProcesso tramitacaoEtapa)
        {
            try
            {
                // Buscar a última tramitação do processo
                var ultimaTramitacao = _processoTramitacaoServico
                    .ListarAtivos()
                    .Where(x => x.IdProcesso.Equals(tramitacaoEtapa.IdEtapa))
                    .OrderByDescending(x => x.DataCriacao) // Substitua "DataCriacao" pelo nome da propriedade relevante
                    .FirstOrDefault();

                // Verificar se foi encontrada alguma tramitação para o processo
                if (ultimaTramitacao == null)
                {
                    return NoContent();
                }

                // Buscar a última etapa da tramitação
                var ultimaEtapa = _gerenciaPrazoServico
                    .ListarAtivos()
                    .FirstOrDefault(x => x.IdEtapaProcesso.Equals(ultimaTramitacao.IdEtapaProcesso) && x.IdGerencia.Equals(ultimaTramitacao.IdOrgaoDestino));

                // Verificar se foi encontrada alguma etapa
                if (ultimaEtapa == null)
                {
                    return NoContent();
                }

                // Retornar a última etapa encontrada
                return StatusCode(200, ultimaEtapa);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = $"Erro ao buscar Etapa do processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar Etapa do processo!" });
            }
        }

        //Fim metodo UltimaEtapaProcesso




        [HttpPost("AtualizaTramitacoesEtapaProcesso")]
        public IActionResult AtualizaTramitacoesEtapaProcesso(TramitacaoEtapaProcesso tramitacaoEtapa)
        {
            try
            {
                var processoTramitacao = _gerenciaPrazoServico.ListarAtivos().FirstOrDefault(x=>x.IdEtapaProcesso.Equals(tramitacaoEtapa.IdEtapa) && x.IdGerencia.Equals(tramitacaoEtapa.IdOrgaoDestino));
                var tramitação = _processoTramitacaoServico.RetornaPorId(tramitacaoEtapa.IdTramitacao);
                tramitação.Prazo = processoTramitacao.Prazo;
                tramitação.IdEtapaProcesso = tramitacaoEtapa.IdEtapa;
                if (processoTramitacao == null)
                {
                    return NoContent();
                }

                return StatusCode(200, _processoTramitacaoServico.AtualizaTramitacoesEtapaProcesso(tramitação)); 
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = $"Erro ao buscar tramitacao!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar tramitacao!" });
            }
        }
    }
}
