using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;
using SigProc.Dominio.Entidades;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using SigProc.Aplicacao.Servicos;

namespace SisAgenda.Servico.Controladores
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class GerenciasController : ControllerBase
    {
        private readonly IGerenciaServico _gerenciaServico;
        private IMapper _mapper;
        public GerenciasController(IGerenciaServico gerenciaServico, IMapper mapper)
        {
            _gerenciaServico = gerenciaServico;
            _mapper = mapper;
        }

        [HttpPost("Cadastrar")]
        public IActionResult Post([FromBody] GerenciaModelo[] gerencia)
        {
            //var sUsuario = _usuarioServico.BuscarPorEmail(User.Identity.Name);
            try
            {
                var cadastro = _gerenciaServico.Inserir(_mapper.Map<Gerencia>(gerencia));

                //Log.ForContext("Action", $"CadastrarU").Information($"O usuário: {sUsuario}, cadastrou o usuário: {usuario.Nome}.");
                return StatusCode(201, new { mensagem = "Gerência cadastrado com sucesso!" });
            }
            catch (ValidationException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Errors, mensagem = "Erro ao cadastrar gerência!" });
            }
            catch (ArgumentException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar gerência!" });
            }
            catch (Exception ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar gerência!" });
            }
        }

        [HttpPut("Editar")]
        public IActionResult Editar([FromBody] GerenciaUpdateModelo gerenciaUpdate)
        {
            try
            {
                //var gerenciaAtualizada = gerenciaUpdate;
                var gerenciaAtualizada = _gerenciaServico.Atualizar(_mapper.Map<Gerencia>(gerenciaUpdate));
                return StatusCode(200, new { gerenciaAtualizada, mensagem = "Gerência editada com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao editar gerência!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao editar gerência!" });
            }
        }


        //[HttpPut("Editar")]
        //public IActionResult Editar([FromBody] GerenciaUpdateModelo gerenciaUpdate)
        //{
        //    try
        //    {
        //        if (gerenciaUpdate.Prazo <= 0)
        //            return StatusCode(400, new { mensagem = "Informe o prazo da gerência!" });

        //        var gerenciaAtualizar = _gerenciaServico.Atualizar(gerenciaUpdate);
        //        return StatusCode(200, new { gerenciaAtualizar, mensagem = "Gerência editada com sucesso!" });

        //      //  var contato = _gerenciaServico.Atualizar(_mapper.Map<Gerencia>(gerencia));
        //      //  return StatusCode(200, new { contato, mensagem = "Gerência editada com sucesso!" });
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        return StatusCode(400, new { ex.Message, mensagem = "Erro ao editar gerência!" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, new { ex.Message, mensagem = "Erro ao editar gerência!" });
        //    }
        //}

        [HttpDelete("Excluir/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var contato = _gerenciaServico.Excluir(id);
                return StatusCode(200, new { contato, mensagem = "Gerência inativado com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao inativar gerência!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao inativar gerência!" });
            }
        }

        [HttpGet("Consultar")]
        public IActionResult ListarTudo()
        {
            try
            {
                var gerencias = _gerenciaServico.ListarTudo();
                if (gerencias.Count == 0)
                    return NoContent();

                return StatusCode(200, gerencias);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar gerência!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar gerência!" });
            }
        }

        [HttpGet("BuscarPorID/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var gerencia = _gerenciaServico.RetornaPorId(id);
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
