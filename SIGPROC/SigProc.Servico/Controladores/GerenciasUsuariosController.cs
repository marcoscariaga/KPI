using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos;
using SigProc.Aplicacao.Servicos;
using SigProc.Dominio.Entidades;
using GerenciaUsuario = SigProc.Dominio.Entidades.GerenciaUsuario;

namespace SigProc.Servico.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerenciasUsuariosController : ControllerBase
    {
        private readonly IGerenciaUsuarioServico _gerenciaUsuario;
        private IMapper _mapper;

        public GerenciasUsuariosController(IGerenciaUsuarioServico gerenciaUsuario, IMapper mapper)
        {
            _gerenciaUsuario = gerenciaUsuario;
            _mapper = mapper;
        }

        [HttpPost("Cadastrar")]
        public IActionResult Post([FromBody] GerenciaUsuarioModelo gerenciaUsuario)
        {
            
            try
            {
                var cadastro = _gerenciaUsuario.Inserir(_mapper.Map<GerenciaUsuario>(gerenciaUsuario));

                //Log.ForContext("Action", $"CadastrarU").Information($"O usuário: {sUsuario}, cadastrou o usuário: {usuario.Nome}.");
                return StatusCode(201, new { cadastro, mensagem = "Usuário associado com sucesso!" });

            }
            catch (ValidationException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Errors, mensagem = "Erro ao associar usuário!" });
            }

            catch (ArgumentException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao associar usuário!" });
            }
            catch (Exception ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao associar usuário!" });
            }
        }

        [HttpPut("Editar")]
        public IActionResult Editar([FromBody] GerenciaUsuario gerenciaUsuario)
        {
            try
            {
                var prazo = _gerenciaUsuario.Atualizar(gerenciaUsuario);
                return StatusCode(200, new { prazo, mensagem = "Usuário associado com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao associar usuário!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao associar usuário!" });
            }
        }

        [HttpDelete("Excluir/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var contato = _gerenciaUsuario.Excluir(id);
                return StatusCode(200, new { contato, mensagem = "Usuário desassociado com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao desassociar usuário!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao desassociar usuário!" });
            }
        }

        [HttpGet("Consultar")]
        public IActionResult ListarAtivos()
        {
            try
            {
                var prazos = _gerenciaUsuario.ListarAtivos();
                if (prazos.Count == 0)
                    return NoContent();

                return StatusCode(200, prazos);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar Usuários!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar Usuários!" });
            }
        }

        [HttpGet("BuscarPorID/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var prazo = _gerenciaUsuario.RetornaPorId(id);
                if (prazo == null)
                    return NoContent();

                return StatusCode(200, prazo);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao buscar Usuários!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar Usuários!" });
            }
        }
        [HttpGet("BuscarPorIdGerencia/{id}")]
        public IActionResult BuscarPorIdGerencia(int id)
        {
            try
            {
                var prazo = _gerenciaUsuario.ListarAtivos().Where(x=>x.IdGerencia.Equals(id)).ToList();
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

        [HttpGet("BuscarPorIdGerenciaUsuario/{id}")]
        public IActionResult GetByIdUsuario(int id)
        {
            try
            {
                var gerencia = _gerenciaUsuario.ListarTudo().Where(a => a.IdUsuarioGerencia == id);
                if (gerencia == null)
                    return NoContent();

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
    }
}
