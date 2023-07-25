using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;
using SigProc.Dominio.Entidades;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos;
using SigProc.Aplicacao.Servicos;

namespace SisAgenda.Servico.Controladores

{  //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentosAuxiliaresController : ControllerBase
    {
        private readonly IInstrumentosAuxiliaresServico _instrumentosAuxiliaresServico;
        private IMapper _mapper;
        public InstrumentosAuxiliaresController(IInstrumentosAuxiliaresServico instrumentosAuxiliaresServico, IMapper mapper)
        {
            _instrumentosAuxiliaresServico = instrumentosAuxiliaresServico;
            _mapper = mapper;
            
        }

        // ***************** Instrumentos Auxiliares *****************

        [HttpPost("CadastrarInstrumentosAuxiliares")]
        public IActionResult PostInstrumentosAuxiliares([FromBody] InstrumentosAuxiliaresModelo instrumentosAuxiliares)
        {
            //var sUsuario = _usuarioServico.BuscarPorEmail(User.Identity.Name);
            try
            {
                var instrumentosAuxiliaresCadastro = _instrumentosAuxiliaresServico.Inserir(_mapper.Map<InstrumentosAuxiliares>(instrumentosAuxiliares));
                //Log.ForContext("Action", $"CadastrarU").Information($"O usuário: {sUsuario}, cadastrou o usuário: {usuario.Nome}.");
                return StatusCode(201, new { instrumentosAuxiliaresCadastro, mensagem = "Instrumentos Auxiliares cadastrado com sucesso!" });
            }
            catch (ValidationException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Errors, mensagem = "Erro ao cadastrar a Instrumentos Auxiliares!" });
            }
            catch (ArgumentException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar a Instrumentos Auxiliares!" });
            }
            catch (Exception ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar a Instrumentos Auxiliares!" });
            }
        }
        [HttpPut("EditarInstrumentosAuxiliares")]
        public IActionResult EditarInstrumentosAuxiliares([FromBody] InstrumentosAuxiliares instrumentosAuxiliares)
        {
            try
            {
                var instrumentosAuxiliaresAtualizada = _instrumentosAuxiliaresServico.Atualizar(instrumentosAuxiliares);
                return StatusCode(200, new { instrumentosAuxiliaresAtualizada, mensagem = "Instrumentos Auxiliares editar com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao editar a Instrumentos Auxiliares!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao editar a Instrumentos Auxiliares!" });
            }
        }

        [HttpDelete("ExcluirInstrumentosAuxiliares/{id}")]
        public IActionResult DeleteInstrumentosAuxiliares(int id)
        {
            try
            {
                var instrumentosAuxiliaresExcluir = _instrumentosAuxiliaresServico.Excluir(id);
                return StatusCode(200, new { instrumentosAuxiliaresExcluir, mensagem = "Instrumentos Auxiliares inativado com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao inativar a Instrumentos Auxiliares!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao inativar a Contratacao!" });
            }
        }

        [HttpGet("ConsultarInstrumentosAuxiliares")]
        public IActionResult ListarTudoInstrumentosAuxiliares()
        {
            try
            {
                var instrumentosAuxiliaresConsultar = _instrumentosAuxiliaresServico.ListarTudo();
                if (instrumentosAuxiliaresConsultar.Count == 0)
                    return NoContent();
                return StatusCode(200, instrumentosAuxiliaresConsultar);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar a Instrumentos Auxiliares!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar a Instrumentos Auxiliares!" });
            }
        }

        [HttpGet("BuscarInstrumentosAuxiliaresPorID/{id}")]
        public IActionResult GetInstrumentosAuxiliaresById(int id)
        {
            try
            {
                var instrumentosAuxiliaresBuscar = _instrumentosAuxiliaresServico.RetornaPorId(id);
                if (instrumentosAuxiliaresBuscar == null)
                    return NoContent();
                return StatusCode(200, instrumentosAuxiliaresBuscar);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar a Instrumentos Auxiliares!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar a Instrumentos Auxiliares!" });
            }
        }
    }
}


