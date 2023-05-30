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
        /*
     [HttpPut("Editar")]
     public IActionResult Editar([FromBody] ProcessoTramitacao processoTramitacao)
     {
         try
         {
             var contato = _processoTramitacaoServico.Atualizar(processoTramitacao);
             return StatusCode(200, new { contato, mensagem = "Tramitacao editada com sucesso!" });
         }
         catch (ArgumentException ex)
         {
             return StatusCode(400, new { ex.Message, mensagem = "Erro ao editar tramitacao!" });
         }
         catch (Exception ex)
         {
             return StatusCode(500, new { ex.Message, mensagem = "Erro ao editar tramitacao!" });
         }
     }

     [HttpDelete("Excluir/{id}")]
     public IActionResult Delete(int id)
     {
         try
         {
             var contato = _processoTramitacaoServico.Excluir(id);
             return StatusCode(200, new { contato, mensagem = "Tramitacao inativado com sucesso!" });
         }
         catch (ArgumentException ex)
         {
             return StatusCode(400, new { ex.Message, mensagem = "Erro ao inativar tramitacao!" });
         }
         catch (Exception ex)
         {
             return StatusCode(500, new { ex.Message, mensagem = "Erro ao inativar tramitacao!" });
         }
     }

     [HttpGet("Consultar")]
     public IActionResult ListarTudo()
     {
         try
         {
             var processoTramitacao = _processoTramitacaoServico.ListarAtivos();
             if (processoTramitacao.Count == 0)
                 return NoContent();

             return StatusCode(200, processoTramitacao);
         }
         catch (ArgumentException ex)
         {
             return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar tramitacao!" });
         }
         catch (Exception ex)
         {

             return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar tramitacao!" });
         }
     }
     */

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

        [HttpPost("AtualizaTramitacoesEtapaProcesso")]
        public IActionResult AtualizaTramitacoesEtapaProcesso(TramitacaoEtapaProcesso tramitacaoEtapa)
        {
            try
            {
                var processoTramitacao = _gerenciaPrazoServico.ListarAtivos().FirstOrDefault(x=>x.IdEtapaProcesso.Equals(tramitacaoEtapa.IdEtapa) && x.IdGerencia.Equals(tramitacaoEtapa.IdOrgaoDestino));
                var tramitação = _processoTramitacaoServico.RetornaPorId(tramitacaoEtapa.IdTramitacao);
                tramitação.Prazo = processoTramitacao.Prazo;
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
