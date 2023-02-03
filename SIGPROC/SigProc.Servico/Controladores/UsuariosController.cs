using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos.ModeloEntrada;
using SigProc.Domain.Entidades;
using System.ComponentModel.DataAnnotations;


namespace SigProc.Servico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioServico _usuarioServico;
        private IMapper _mapper;
        public UsuariosController(IUsuarioServico usuarioServico, IMapper mapper)
        {
            _usuarioServico = usuarioServico;
            _mapper = mapper;
        }

        [HttpPost("Cadastrar")]
        public IActionResult Post([FromBody] UsuarioModelo usuario)
        {
            try
            {
                var cadastro = _usuarioServico.Inserir(_mapper.Map<Usuario>(usuario));

                return StatusCode(201, new { cadastro, mensagem = "Usuário cadastrado com sucesso!" });
            }
            catch (ValidationException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar usuário!" });
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
        [HttpPut("Editar")]
        public IActionResult Editar([FromBody] UsuarioModelo usuario)
        {
            try
            {
                var contato = _usuarioServico.Atualizar(_mapper.Map<Usuario>(usuario));
                return StatusCode(200, new { contato, mensagem = "Usuário alterado com sucesso!" });
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

        [HttpDelete("Excluir/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var contato = _usuarioServico.Excluir(id);
                return StatusCode(200, new { contato, mensagem = "Usuário inativado com sucesso!" });
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

        [HttpGet("Consultar")]
        public IActionResult ListarTudo()
        {
            try
            {
                var usuarios = _usuarioServico.ListarTudo();
                if (usuarios.Count == 0)
                    return NoContent();

                return StatusCode(200, usuarios);
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

        [HttpGet("BuscarPorID/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var contato = _usuarioServico.RetornaPorId(id);
                if (contato == null)
                    return NoContent();

                return StatusCode(200, contato);
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
