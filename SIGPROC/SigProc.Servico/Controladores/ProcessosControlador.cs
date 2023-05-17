using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;
using SigProc.Dominio.Entidades;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos;

namespace SisAgenda.Servico.Controladores
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessosController : ControllerBase
    {
        private readonly IProcessoServico _processoServico;
        private IMapper _mapper;
        public ProcessosController(IProcessoServico processoServico, IMapper mapper)
        {
            _processoServico = processoServico;
            _mapper = mapper;
        }

        [HttpPost("Cadastrar")]
        public IActionResult Post([FromBody] ProcessoModelo processo)
        {
            //var sUsuario = _usuarioServico.BuscarPorEmail(User.Identity.Name);
            try
            {
                processo.IdUsuarioCadastro = 1;
                var cadastro = _processoServico.Inserir(_mapper.Map<Processo>(processo));

                //Log.ForContext("Action", $"CadastrarU").Information($"O usuário: {sUsuario}, cadastrou o usuário: {usuario.Nome}.");
                return StatusCode(201,new { cadastro, mensagem = "Processo cadastrado com sucesso!" } );
            }
            catch (ValidationException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Errors, mensagem = "Erro ao cadastrar processo!" });
            }
            catch (ArgumentException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar processo!" });
            }
            catch (Exception ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar processo!" });
            }
        }

        [HttpPut("Editar")]
        public IActionResult Editar([FromBody] Processo processo)
        {
            try
            {
                var contato = _processoServico.Atualizar(processo);
                return StatusCode(200, new { contato, mensagem = "Processo editada com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao editar processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao editar processo!" });
            }
        }

        [HttpDelete("Excluir/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var contato = _processoServico.Excluir(id);
                return StatusCode(200, new{ contato, mensagem = "Processo inativado com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao inativar processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao inativar processo!" });
            }
        }

        [HttpGet("Consultar")]
        public IActionResult ListarTudo()
        {
            try
            {
                var processos = _processoServico.ListarTudo();
                if (processos.Count == 0)
                    return NoContent();

                return StatusCode(200, processos);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar processo!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar processo!" });
            }
        }
        [HttpGet("BuscarPorNumeroProcesso/{numeroProcesso}")]
        public IActionResult BuscarPorNumeroProcesso(string numeroProcesso)
        {
            try
            {
                var processos = _processoServico.ListarTudo().Where(x=>x.NumProcesso.Equals(numeroProcesso)).FirstOrDefault();

                return StatusCode(200, processos);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar processo!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar processo!" });
            }
        }
        [HttpGet("BuscarPorID/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var processo = _processoServico.RetornaPorId(id);
                if (processo == null)
                    return NoContent();

                return StatusCode(200, processo);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao buscar processo!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar processo!" });
            }
        }
    }
}
