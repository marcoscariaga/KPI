using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos;
using FluentValidation;
using SigProc.Aplicacao.Servicos;
using SigProc.Domain.Entidades;
using SigProc.Domimio.Entidades;
using SigProc.infra.dados.Mapeamentos;

namespace SigProc.Servico.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrioridadeController : ControllerBase
    {
        private readonly IProcessoTramitacaoServico _processoTramitacaoServico;
        private readonly IPrioridadeServico _prioridadeServico;
        private readonly IStatusProcessoServico _statusServico;
        private readonly IProcessoServico _processoServico;
        private IMapper _mapper;

        public PrioridadeController(IProcessoTramitacaoServico processoTramitacaoServico, IPrioridadeServico mensagemServico, IMapper mapper, IStatusProcessoServico statusServico, IProcessoServico processoServico)
        {
            _processoTramitacaoServico = processoTramitacaoServico;
            _prioridadeServico = prioridadeServico;
            _mapper = mapper;
            _statusServico = statusServico;
            _processoServico = processoServico;
        }
        [HttpPost("CadastrarPrioridadeTramitacao")]
        public IActionResult CadastrarPrioridadeTramitacao([FromBody] PrioridadeModelo mensagem)
        {
            try
            {
                var cadastro = _prioridadeServico.Inserir(_mapper.Map<Prioridade>(mensagem));
         
                return StatusCode(201, new { cadastro, mensagem = "Prioridade cadastrada com sucesso!" });
            }
            catch (ValidationException ex)
            {

                return StatusCode(400, new { ex.Errors, mensagem = "Erro ao cadastrar prioridade!" });
            }
            catch (ArgumentException ex)
            {

                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar prioridade!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar prioridade!" });
            }
        }
        [HttpGet("BuscarPrioridadePorIdTramitacao/{id}")]
        public IActionResult BuscarPrioridadePorIdTramitacao(int id)
        {
            try
            {
                var mensagem = _prioridadeServico.BuscarPrioridadePorIdTramitacao(id);

                return StatusCode(200, mensagem);
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar Prioridade!" });
            }
        }
        [HttpGet("BuscarPrioridadePorIdProcesso/{id}")]
        public IActionResult BuscarPrioridadePorIdProcesso(int id)
        {
            try
            {
                var mensagem = _prioridadeServico.BuscarPrioridadePorIdProcesso(id);

                return StatusCode(200, mensagem);
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar Prioridade!" });
            }
        }
        [HttpGet("BuscarUltimaPrioridadePorIdProcesso/{id}")]
        public IActionResult BuscarUltimaPrioridadePorIdProcesso(int id)
        {
            try
            {
                var processoTramitacao = _PrioridadeServico.BuscarUltimaPrioridadePorIdProcesso(id);
                if (processoTramitacao == null)
                    return NoContent();

                return StatusCode(200, processoTramitacao);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = $"Erro ao buscar Prioridade!" });
            }
        }

        //[HttpPost("CadastrarStatusCancelamentoEncerramento")]
        //public IActionResult CadastrarStatusCancelamentoEncerramento([FromBody] PrioridadeModelo mensagem)
        //{
        //    try
        //    {
        //        if (mensagem.Descricao != null)
        //        {
        //            var status = _statusServico.ListarTudo().Where(x => x.Descricao.Equals(mensagem.StatusProcesso)).FirstOrDefault();
        //            var processo = _processoServico.RetornaPorId((int)mensagem.IdProcesso);
        //            processo.IdStatusProcesso = status.Id;

        //            Mensagem mensagemCad = new Mensagem
        //            {
        //                IdTramitacao = mensagem.IdTramitacao,
        //                Descricao = mensagem.Descricao,
        //                IdGerencia = mensagem.IdGerencia,
        //                IdProcesso = mensagem.IdProcesso,
        //                IdUsuario = mensagem.IdUsuario,
        //                IdStatusProcesso = status.Id
        //            };
        //            _mensagemServico.Inserir(mensagemCad);

        //            return StatusCode(200, mensagemCad);
        //        }
        //        else {
        //            return Ok(new { mensagem = "Informe uma mensagem para mudança de status!" });
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar tramitacao!" });
        //    }
        //}
    }
}
