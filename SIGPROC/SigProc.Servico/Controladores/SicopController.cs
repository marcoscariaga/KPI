using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SigProc.Aplicacao.Contratos;
using SigProc.Domimio.Entidades;

namespace SigProc.Servico.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class SicopController : ControllerBase
    {
        private readonly IDadosDoProcessoSicopServico _appSicopProcesso;
        private IMapper _mapper;

        public SicopController(IDadosDoProcessoSicopServico appSicopProcesso, IMapper mapper)
        {
            _appSicopProcesso = appSicopProcesso;
            _mapper = mapper;
        }
        /// <summary>
        /// Serviço de Controle de Processos
        /// </summary>

        [HttpPost("ConsultarProcessoSicop")]
        public IActionResult ConsultarProcessoSicop(string numeroProcesso)
        {
            var processo = _appSicopProcesso.ConsultarProcesso(numeroProcesso);
            if (processo.StatusLine == "Consulta Efetuada")
                return Ok(_appSicopProcesso.Inserir(processo));


            return NoContent();


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
    }
}
