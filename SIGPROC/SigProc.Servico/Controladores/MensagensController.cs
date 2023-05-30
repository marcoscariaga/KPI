﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos;
using FluentValidation;
using SigProc.Aplicacao.Servicos;
using SigProc.Domain.Entidades;
using SigProc.Domimio.Entidades;

namespace SigProc.Servico.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensagensController : ControllerBase
    {
        private readonly IProcessoTramitacaoServico _processoTramitacaoServico;
        private readonly IMensagemServico _mensagemServico;
        private IMapper _mapper;

        public MensagensController(IProcessoTramitacaoServico processoTramitacaoServico, IMensagemServico mensagemServico, IMapper mapper)
        {
            _processoTramitacaoServico = processoTramitacaoServico;
            _mensagemServico = mensagemServico;
            _mapper = mapper;
        }
        [HttpPost("CadastrarMensagemTramitacao")]
        public IActionResult CadastrarMensagemTramitacao([FromBody] MensagemModelo mensagem)
        {
            try
            {
                var cadastro = _mensagemServico.Inserir(_mapper.Map<Mensagem>(mensagem));
         
                return StatusCode(201, new { cadastro, mensagem = "Mensagem cadastrada com sucesso!" });
            }
            catch (ValidationException ex)
            {

                return StatusCode(400, new { ex.Errors, mensagem = "Erro ao cadastrar mensagem!" });
            }
            catch (ArgumentException ex)
            {

                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar mensagem!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar mensagem!" });
            }
        }
        [HttpGet("BuscarMensagemPorIdTramitacao/{id}")]
        public IActionResult BuscarMensagemPorIdTramitacao(int id)
        {
            try
            {
                var mensagem = _mensagemServico.BuscarMensagemPorIdTramitacao(id);

                return StatusCode(200, mensagem);
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar mensagem!" });
            }
        }
        [HttpGet("BuscarMensagemPorIdProcesso/{id}")]
        public IActionResult BuscarMensagemPorIdProcesso(int id)
        {
            try
            {
                var mensagem = _mensagemServico.BuscarMensagemPorIdProcesso(id);

                return StatusCode(200, mensagem);
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar mensagem!" });
            }
        }
    }
}