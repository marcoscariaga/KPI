﻿using Microsoft.AspNetCore.Http;
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
    public class EtapaController : ControllerBase
    {
        private readonly IEtapaProcessoServico _etapaProcessoServico;
        private IMapper _mapper;
        private readonly IGerenciaPrazoServico _gerenciaPrazoServico;
        public EtapaController(IEtapaProcessoServico etapaProcessoServico, IMapper mapper, IGerenciaPrazoServico gerenciaPrazoServico)
        {
            _etapaProcessoServico = etapaProcessoServico;
            _mapper = mapper;
            _gerenciaPrazoServico = gerenciaPrazoServico;
        }

        // ***************** ETAPA PROCESSO *****************

        [HttpPost("CadastrarEtapaProcesso")]
        public IActionResult PostEtapaProcesso([FromBody] EtapaProcessoModelo etapaProcesso)
        {
            //var sUsuario = _usuarioServico.BuscarPorEmail(User.Identity.Name);
            try
            {
                var etapaProcessoCadastro = _etapaProcessoServico.Inserir(_mapper.Map<EtapaProcesso>(etapaProcesso));
                //Log.ForContext("Action", $"CadastrarU").Information($"O usuário: {sUsuario}, cadastrou o usuário: {usuario.Nome}.");
                return StatusCode(201, new { etapaProcessoCadastro, mensagem = "Etapa do Processo cadastrado com sucesso!" });
            }
            catch (ValidationException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Errors, mensagem = "Erro ao cadastrar a etapa do Processo!" });
            }
            catch (ArgumentException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar a etapa do Processo!" });
            }
            catch (Exception ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar a etapa do Processo!" });
            }
        }
        [HttpPut("EditarEtapaProcesso")]
        public IActionResult EditarEtapaProcesso([FromBody] EtapaProcesso etapaProcesso)
        {
            try
            {
                var etapaProcessoAtualizada = _etapaProcessoServico.Atualizar(etapaProcesso);
                return StatusCode(200, new { etapaProcessoAtualizada, mensagem = "Etapa do Processo editar com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao editar a etapa do Processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao editar a etapa do Processo!" });
            }
        }

        [HttpDelete("ExcluirEtapaProcesso/{id}")]
        public IActionResult DeleteStatusProceso(int id)
        {
            try
            {
                var etapaProcessoExcluir = _etapaProcessoServico.Excluir(id);
                return StatusCode(200, new { etapaProcessoExcluir, mensagem = "Etapa do Processo inativado com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao inativar a etapa do Processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao inativar a etapa do Processo!" });
            }
        }

        [HttpGet("ConsultarEtapaProcesso")]
        public IActionResult ListarTudoEtapaProcesso()
        {
            try
            {
                var etapaProcessoConsultar = _etapaProcessoServico.ListarTudo();
                if (etapaProcessoConsultar.Count == 0)
                    return NoContent();
                return StatusCode(200, etapaProcessoConsultar);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar a etapa do Processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar a etapa Processo!" });
            }
        }

        [HttpGet("BuscarEtapaProcessoPorID/{id}")]
        public IActionResult GetEtapaProcessoById(int id)
        {
            try
            {
                var etapaProcessoBuscar = _etapaProcessoServico.RetornaPorId(id);
                if (etapaProcessoBuscar == null)
                    return NoContent();
                return StatusCode(200, etapaProcessoBuscar);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar a etapa do Processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar a etapa do Processo!" });
            }
        }
        [HttpGet("ConsultarEtapaProcessoPorGerencia/{id}")]
        public IActionResult ConsultarEtapaProcessoPorGerencia(int id)
        {
            try
            {
                var etapaProcessoConsultar = _gerenciaPrazoServico.ListarAtivos().Where(x => x.IdGerencia == id && x.IdEtapaProcesso != null).ToList(); 
                if (etapaProcessoConsultar.Count == 0)
                    return NoContent();
                return StatusCode(200, etapaProcessoConsultar);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar a etapa do Processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar a etapa Processo!" });
            }
        }
       
    }
}

