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
    public class StatusProcessoController : ControllerBase
    {
        private readonly IStatusProcessoServico _statusProcessoServico;
        private IMapper _mapper;
        public StatusProcessoController(IStatusProcessoServico statusProcessoServico, IMapper mapper)
        {
            _statusProcessoServico = statusProcessoServico;
            _mapper = mapper;
        }

        // ***************** STATUS PROCESSO *****************

        [HttpPost("CadastrarStatusProcesso")]
        public IActionResult PostStatusProcesso([FromBody] StatusProcessoModelo statusProcesso)
        {
            //var sUsuario = _usuarioServico.BuscarPorEmail(User.Identity.Name);
            try
            {
                var statusProcessoCadastro = _statusProcessoServico.Inserir(_mapper.Map<StatusProcesso>(statusProcesso));
                //Log.ForContext("Action", $"CadastrarU").Information($"O usuário: {sUsuario}, cadastrou o usuário: {usuario.Nome}.");
                return StatusCode(201, new { statusProcessoCadastro, mensagem = "Status do Processo cadastrado com sucesso!" });
            }
            catch (ValidationException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Errors, mensagem = "Erro ao cadastrar o status do Processo!" });
            }
            catch (ArgumentException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar o status do Processo!" });
            }
            catch (Exception ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar o status do Processo!" });
            }
        }
        [HttpPut("EditarStatusProcesso")]
        public IActionResult EditarStatusProcesso([FromBody] StatusProcesso statusProcesso)
        {
            try
            {
                var statusProcessoAtualizada = _statusProcessoServico.Atualizar(statusProcesso);
                return StatusCode(200, new { statusProcessoAtualizada, mensagem = "Status do Processo editado com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao editar o status do Processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao editar o status do Processo!" });
            }
        }

        [HttpDelete("ExcluirStatusProcesso/{id}")]
        public IActionResult DeleteStatusProceso(int id)
        {
            try
            {
                var statusProcessoExcluir = _statusProcessoServico.Excluir(id);
                return StatusCode(200, new { statusProcessoExcluir, mensagem = "Status do Processo inativado com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao inativar o status do Processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao inativar o status do Processo!" });
            }
        }

        [HttpGet("ConsultarStatusProcesso")]
        public IActionResult ListarTudoStatusProcesso()
        {
            try
            {
                var statusProcessoConsultar = _statusProcessoServico.ListarTudo();
                if (statusProcessoConsultar.Count == 0)
                    return NoContent();
                return StatusCode(200, statusProcessoConsultar);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar o Status do Processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar o Status do Processo!" });
            }
        }

        [HttpGet("BuscarStatusProcessoPorID/{id}")]
        public IActionResult GetStatusProcessoById(int id)
        {
            try
            {
                var statusProcessoBuscar = _statusProcessoServico.RetornaPorId(id);
                if (statusProcessoBuscar == null)
                    return NoContent();
                return StatusCode(200, statusProcessoBuscar);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar o status do Processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar o status do Processo!" });
            }
        }
    }
}

