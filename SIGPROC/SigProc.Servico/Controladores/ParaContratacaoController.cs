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
    public class ParaContratacaoController : ControllerBase
    {
        private readonly IParaContratacaoServico _paraContratacaoServico;
        private IMapper _mapper;
        public ParaContratacaoController(IParaContratacaoServico paraContratacaoServico, IMapper mapper)
        {
            _paraContratacaoServico = paraContratacaoServico;
            _mapper = mapper;
            
        }

        // ***************** Para Contratacao *****************

        [HttpPost("CadastrarParaContratacao")]
        public IActionResult PostParaContratacao([FromBody] ParaContratacaoModelo paraContratacao)
        {
            //var sUsuario = _usuarioServico.BuscarPorEmail(User.Identity.Name);
            try
            {
                var paraContratacaoCadastro = _paraContratacaoServico.Inserir(_mapper.Map<ParaContratacao>(paraContratacao));
                //Log.ForContext("Action", $"CadastrarU").Information($"O usuário: {sUsuario}, cadastrou o usuário: {usuario.Nome}.");
                return StatusCode(201, new { paraContratacaoCadastro, mensagem = "Contratacao cadastrado com sucesso!" });
            }
            catch (ValidationException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Errors, mensagem = "Erro ao cadastrar a Contratacao!" });
            }
            catch (ArgumentException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar a Contratacao!" });
            }
            catch (Exception ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar a Contratacao!" });
            }
        }
        [HttpPut("EditarParaContratacao")]
        public IActionResult EditarParaContratacao([FromBody] ParaContratacao paraContratacao)
        {
            try
            {
                var paraContratacaoAtualizada = _paraContratacaoServico.Atualizar(paraContratacao);
                return StatusCode(200, new { paraContratacaoAtualizada, mensagem = "Contratacao editar com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao editar a Contratacao!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao editar a Contratacao!" });
            }
        }

        [HttpDelete("ExcluirParaContratacao/{id}")]
        public IActionResult DeleteParaContratacao(int id)
        {
            try
            {
                var paraContratacaoExcluir = _paraContratacaoServico.Excluir(id);
                return StatusCode(200, new { paraContratacaoExcluir, mensagem = "Contratacao inativado com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao inativar a Contratacao!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao inativar a Contratacao!" });
            }
        }

        [HttpGet("ConsultarParaContratacao")]
        public IActionResult ListarTudoParaContratacao()
        {
            try
            {
                var paraContratacaoConsultar = _paraContratacaoServico.ListarTudo();
                if (paraContratacaoConsultar.Count == 0)
                    return NoContent();
                return StatusCode(200, paraContratacaoConsultar);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar a Contratacao!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar a Contratacao!" });
            }
        }

        [HttpGet("BuscarParaContratacaoPorID/{id}")]
        public IActionResult GetParaContratacaoById(int id)
        {
            try
            {
                var paraContratacaoBuscar = _paraContratacaoServico.RetornaPorId(id);
                if (paraContratacaoBuscar == null)
                    return NoContent();
                return StatusCode(200, paraContratacaoBuscar);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar a Contratacao!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar a Contratacao!" });
            }
        }
    }
}


