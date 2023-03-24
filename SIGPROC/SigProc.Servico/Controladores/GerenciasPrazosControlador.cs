using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;
using SigProc.Dominio.Entidades;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos;
using Microsoft.EntityFrameworkCore;

namespace SisAgenda.Servico.Controladores
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class GerenciasPrazosController : ControllerBase
    {
        private readonly IGerenciaPrazoServico _gerenciaPrazoServico;
        private IMapper _mapper;
        public GerenciasPrazosController(IGerenciaPrazoServico gerenciaPrazoServico, IMapper mapper)
        {
            _gerenciaPrazoServico = gerenciaPrazoServico;
            _mapper = mapper;
        }

        [HttpPost("Cadastrar")]
        public IActionResult Post([FromBody] GerenciaPrazoModelo gerenciaPrazo)
        {
            //var sUsuario = _usuarioServico.BuscarPorEmail(User.Identity.Name);

            try
            {
                if (gerenciaPrazo.Prazo <= 0)
                    return StatusCode(400, new { mensagem = "Informe o prazo da gerência!" });

                var cadastro = _gerenciaPrazoServico.Inserir(_mapper.Map<GerenciaPrazo>(gerenciaPrazo));

                //Log.ForContext("Action", $"CadastrarU").Information($"O usuário: {sUsuario}, cadastrou o usuário: {usuario.Nome}.");
                return StatusCode(201, new { cadastro, mensagem = "Prazo cadastrado com sucesso!" });

            }
            catch (ValidationException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Errors, mensagem = "Erro ao cadastrar Prazo!" });
            }

            catch (ArgumentException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar Prazo!" });
            }
            catch (Exception ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar Prazo!" });
            }
        }

        [HttpPut("Editar")]
        public IActionResult Editar([FromBody] GerenciaPrazoUpdateModelo gerenciaPrazo)
        {
            try
            {
                if (gerenciaPrazo.Prazo <= 0)
                    return StatusCode(400, new { mensagem = "Informe o prazo da gerência!" });

                // Aqui você pode incluir o id na instância de GerenciaPrazo
                var prazo = _gerenciaPrazoServico.Atualizar(_mapper.Map<GerenciaPrazo>(gerenciaPrazo));
                return StatusCode(200, new { prazo, mensagem = "Prazo editada com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao editar Prazo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao editar gerência!" });
            }
        }

        [HttpDelete("Excluir/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var contato = _gerenciaPrazoServico.Excluir(id);
                return StatusCode(200, new { contato, mensagem = "Prazo inativado com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao inativar Prazo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao inativar Prazo!" });
            }
        }

        [HttpGet("Consultar")]
        public IActionResult ListarTudo()
        {
            try
            {
                var prazos = _gerenciaPrazoServico.ListarTudo();
                if (prazos.Count == 0)
                    return NoContent();

                return StatusCode(200, prazos);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar Prazo!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar Prazo!" });
            }
        }

        [HttpGet("BuscarPrazoPorID/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var prazo = _gerenciaPrazoServico.RetornaPorId(id);
                if (prazo == null)
                    return NoContent();

                return StatusCode(200, prazo);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao buscar Prazo!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar Prazo!" });
            }
        }

        [HttpGet("BuscarPrazoPorGerenciaID/{id}")]
        public IActionResult GetByIdGerencia(int id)
        {
            try
            {
                var prazo = _gerenciaPrazoServico.RetornaPorIdGerencia(id);
                if (prazo == null)
                    return NoContent();

                return StatusCode(200, prazo);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao buscar Prazo!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar Prazo!" });
            }
        }

    }
}
