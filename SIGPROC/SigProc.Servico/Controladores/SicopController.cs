using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace SigProc.Servico.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class SicopController : ControllerBase
    {
        private readonly IDadosDoProcessoSicopServico _appSicopProcesso;
        private readonly IDadosDeTramitacaoSicopServico _appSicopTramitacao;
        private IMapper _mapper;
        private readonly IProcessoServico _appProcesso;
        private readonly IProcessoTramitacaoServico _appProcessoTramitacao;
        public SicopController(IDadosDoProcessoSicopServico appSicopProcesso, IMapper mapper, IDadosDeTramitacaoSicopServico appSicopTramitacao, IProcessoServico appProcesso, IProcessoTramitacaoServico appProcessoTramitacao)
        {
            _appSicopProcesso = appSicopProcesso;
            _mapper = mapper;
            _appSicopTramitacao = appSicopTramitacao;
            _appProcesso = appProcesso;
            _appProcessoTramitacao = appProcessoTramitacao;
        }
        /// <summary>
        /// Serviço de Controle de Processos
        /// </summary>

        [HttpPost("ConsultarProcessoSicop")]
        public IActionResult ConsultarProcessoSicop(string numeroProcesso)
        {
            var processo = _appSicopProcesso.ConsultarProcesso(numeroProcesso);
            //if (processo.StatusLine == "Consulta Efetuada")
            //    return Ok(_appSicopProcesso.Inserir(processo));

            var cadastraProcesso = new ProcessoModelo()
            {
                NumProcesso = processo.NumeroDoProcesso,
                Requerente = processo.NomeDoRequerente,
                Assunto = processo.CodigoAssunto,
                TipoDoc = processo.TipoDoDocumento,
                NumDoc = processo.NumeroDoTipoDoDocumento,
                DataCadastroProc =processo.DataDeCadastroDeProcesso,
                DataUltimaTramProc = processo.DataDeDespachoTramitacao,
                OrgaoCadastro = processo.OrgaoDeOrigem,
                OrgaoOrigem = processo.OrgaoOrigemTramitacao,
                OrgaoDestino = processo.OrgaoDestinoTramitacao,
                InfoComplementar = processo.InformacaoComplementar1 + processo.InformacaoComplementar2 + processo.InformacaoComplementar3,
                Prioridade = "alta",
                IdTipoContratacao = 1,
                IdTipoProcesso = 1,
                Observacao = "",
                IdUsuarioCadastro = 1,
                Status = true,
            };
            _appProcesso.Inserir(_mapper.Map<Processo>(cadastraProcesso));

            return Ok(processo);
        }

        [HttpGet("ConsultarProcessoSicopPorNum/{numProcesso}")]
        public IActionResult ConsultarProcessoSicopPorNum(string numProcesso)
        {
            var processo = _appSicopProcesso.ConsultarProcesso(numProcesso);
            if (processo.StatusLine == "Consulta Efetuada")
                return Ok(_appSicopProcesso.Inserir(processo));


            return Ok(processo);
        }

        [HttpPut("EditarProcesso")]
        public IActionResult EditarProcesso([FromBody] DadosDoProcessoSicop processo)
        {
            try
            {
                _appSicopProcesso.Atualizar(processo);
                return StatusCode(200, new { processo, mensagem = "Processo alterado com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar processo!" });
            }
        }

        [HttpDelete("ExcluirProcesso/{id}")]
        public IActionResult ExcluirProcesso(int id)
        {
            try
            {
                var processo = _appSicopProcesso.Excluir(id);
                return StatusCode(200, new { processo, mensagem = "Processo inativado com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar processo!" });
            }
        }

        [HttpGet("ConsultarTodosProcessos")]
        public IActionResult ConsultarTodosProcessos()
        {
            try
            {
                var processos = _appSicopProcesso.ListarTudo();
                if (processos.Count == 0)
                    return NoContent();

                return StatusCode(200, processos);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar processo!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar processo!" });
            }
        }

        [HttpGet("BuscarProcessoPorID/{id}")]
        public IActionResult BuscarProcessoPorID(int id)
        {
            try
            {
                var processos = _appSicopProcesso.RetornaPorId(id);
                if (processos == null)
                    return NoContent();

                return StatusCode(200, processos);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar processo!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar processo!" });
            }
        }

        [HttpGet("BuscarProcessoPorNumeroDeProcesso")]
        public IActionResult BuscarProcessoPorNumeroDeProcesso(string numeroProcesso)
        {
            try
            {
                var processos = _appSicopProcesso.ListarTudo().Where(x => x.NumeroDoProcesso.Equals(numeroProcesso)).FirstOrDefault();
                if (processos == null)
                    return NoContent();

                return StatusCode(200, processos);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar processo!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar processo!" });
            }
        }

        /// <summary>
        /// Serviço de Controle de Tramitações Processos
        /// </summary>

        [HttpPost("ConsultarTramitacaoSicop")]
        public IActionResult ConsultarTramitacaoSicop(string numeroProcesso)
        {
            var tramitacao = _appSicopTramitacao.ConsultarProcesso(numeroProcesso);
            //if (tramitacao.StatusLine == "Consulta efetuada. Tecle (ENTER) p/mais Informacoes.") ;
            //return Ok(_appSicopTramitacao.Inserir(tramitacao));
            
           // var teste = _appProcessoTramitacao.Testando(tramitacao);

            return Ok(tramitacao);
        }

        [HttpPut("EditarTramitacao")]
        public IActionResult EditarTramitacao([FromBody] DadosDeTramitacaoSicop tramitacao)
        {
            try
            {
                _appSicopTramitacao.Atualizar(tramitacao);
                return StatusCode(200, new { tramitacao, mensagem = "Tramitação alterads com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar tramitação!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar tramitação!" });
            }
        }

        [HttpDelete("ExcluirTramitacao/{id}")]
        public IActionResult ExcluirTramitacao(int id)
        {
            try
            {
                var tramitacao = _appSicopTramitacao.Excluir(id);
                return StatusCode(200, new { tramitacao, mensagem = "Usuário inativado com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar usuário!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar usuário!" });
            }
        }

        [HttpGet("ConsultarTodasTramitacoes")]
        public IActionResult ConsultarTodasTramitacoes()
        {
            try
            {
                var tramitacoes = _appSicopTramitacao.ListarTudo();
                if (tramitacoes.Count == 0)
                    return NoContent();

                return StatusCode(200, tramitacoes);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar usuário!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar usuário!" });
            }
        }

        [HttpGet("BuscarTramitacaoPorID/{id}")]
        public IActionResult BuscarTramitacaoPorID(int id)
        {
            try
            {
                var tramitacao = _appSicopTramitacao.RetornaPorId(id);
                if (tramitacao == null)
                    return NoContent();

                return StatusCode(200, tramitacao);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar usuário!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar usuário!" });
            }
        }

        [HttpPost("BuscarTramitacaoPorNumeroDeProcesso")]
        public IActionResult BuscarTramitacaoPorNumeroDeProcesso(ProcessoTramitacao processoTramitacao)
        {
            try
            {
                var tramitacao = _appSicopTramitacao.ListarTudo().Where(x => x.NumeroDoProcesso.Equals(processoTramitacao.NumeroProcesso)).FirstOrDefault();
                //if (tramitacao == null)
                //    return NoContent();

         

                return StatusCode(200, tramitacao);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar usuário!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar usuário!" });
            }
        }
    }
}
