using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos;
using SigProc.Dominio.Entidades;
using SigProc.Aplicacao.Servicos;

namespace SisAgenda.Servico.Controladores

{  //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TiposController : ControllerBase
        {
            private readonly ITipoContratacaoServico _tipoContratacaoServico;
            private readonly ITipoProcessoServico _tipoProcessoServico;
            private readonly ITipoPrazoServico _tipoPrazoServico;
            private readonly ITipoUsuarioGerenciaServico _tipoUsuarioGerenciaServico;
        private IMapper _mapper;
            public TiposController(ITipoContratacaoServico tipoContratacaoServico, ITipoProcessoServico tipoProcessoServico, ITipoPrazoServico tipoPrazoServico, ITipoUsuarioGerenciaServico tipoUsuarioGerenciaServico, IMapper mapper)
            {
                _tipoContratacaoServico = tipoContratacaoServico;
                _tipoProcessoServico = tipoProcessoServico;
                _tipoPrazoServico = tipoPrazoServico;
                _tipoUsuarioGerenciaServico = tipoUsuarioGerenciaServico;
            _mapper = mapper;
            }

        // ***************** TIPO CONTRATAÇÃO *****************

        [HttpPost("CadastrarTipoContratacao")]
            public IActionResult PostTipoContratacao([FromBody] TipoContratacaoModelo tipoContratacao)
            {
                
                try
                {
                    var cadastro = _tipoContratacaoServico.Inserir(_mapper.Map<TipoContratacao>(tipoContratacao));
                    //Log.ForContext("Action", $"CadastrarU").Information($"O usuário: {sUsuario}, cadastrou o usuário: {usuario.Nome}.");
                    return StatusCode(201, new { cadastro, mensagem = "Tipo de Contratação cadastrado com sucesso!" });
                }
                catch (ValidationException ex)
                {
                    //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                    return StatusCode(400, new { ex.Errors, mensagem = "Erro ao cadastrar Tipo de Contratação!" });
                }
                catch (ArgumentException ex)
                {
                    //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                    return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar Tipo de Contratação!" });
                }
                catch (Exception ex)
                {
                    //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                    return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar Tipo de Contratação!" });
                }
            }
            [HttpPut("EditarTipoContratacao")]
            public IActionResult EditarTipoContratacao([FromBody] TipoContratacao tipoContratacao)
            {
                try
                {
                    var contato = _tipoContratacaoServico.Atualizar(_mapper.Map<TipoContratacao>(tipoContratacao));
                    return StatusCode(200, new { contato, mensagem = "Tipo de Contratação editar com sucesso!" });
                }
                catch (ArgumentException ex)
                {
                    return StatusCode(400, new { ex.Message, mensagem = "Erro ao editar Tipo de Contratação!" });
                }
                catch (Exception ex)
                {
                    return StatusCode(500, new { ex.Message, mensagem = "Erro ao editar Tipo de Contratação!" });
                }
            }

            [HttpDelete("ExcluirTipoContratacao/{id}")]
            public IActionResult DeleteTipoContratacao(int id)
            {
                try
                {
                    var contato = _tipoContratacaoServico.Excluir(id);
                    return StatusCode(200, new { contato, mensagem = "Tipo de Contratação inativado com sucesso!" });
                }
                catch (ArgumentException ex)
                {
                    return StatusCode(400, new { ex.Message, mensagem = "Erro ao inativar Tipo de Contratação!" });
                }
                catch (Exception ex)
                {
                    return StatusCode(500, new { ex.Message, mensagem = "Erro ao inativar Tipo de Contratação!" });
                }
            }

            [HttpGet("ConsultarTipoContratacao")]
            public IActionResult ListarTudoTipoContratacao()
            {
                try
                {
                    var tipoContratacao = _tipoContratacaoServico.ListarTudo();
                    if (tipoContratacao.Count == 0)
                        return NoContent();
                    return StatusCode(200, tipoContratacao);
                }
                catch (ArgumentException ex)
                {
                    return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar o Tipo de Contratação!" });
                }
                catch (Exception ex)
                {
                    return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar o Tipo de Contratação!" });
                }
            }

            [HttpGet("BuscarTipoContratacaoPorID/{id}")]
            public IActionResult GetTipoContratacaoById(int id)
            {
                try
                {
                    var buscar = _tipoContratacaoServico.RetornaPorId(id);
                    if (buscar == null)
                        return NoContent();
                    return StatusCode(200, buscar);
                }
                catch (ArgumentException ex)
                {
                    return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar Tipo de Contratação!" });
                }
                catch (Exception ex)
                {
                    return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar Tipo de Contratação!" });
                }
            }


        // ***************** TIPO PROCESSO *****************

        [HttpPost("CadastrarTipoProcesso")]
        public IActionResult PostTipoProcesso([FromBody] TipoProcessoModelo tipoProcesso)
        {
            
            try
            {
                var cadastro = _tipoProcessoServico.Inserir(_mapper.Map<TipoProcesso>(tipoProcesso));
                //Log.ForContext("Action", $"CadastrarU").Information($"O usuário: {sUsuario}, cadastrou o usuário: {usuario.Nome}.");
                return StatusCode(201, new { cadastro, mensagem = "Tipo de Processo cadastrado com sucesso!" });
            }
            catch (ValidationException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Errors, mensagem = "Erro ao cadastrar Tipo de Processo!" });
            }
            catch (ArgumentException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar Tipo de Processo!" });
            }
            catch (Exception ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar Tipo de Processo!" });
            }
        }
        [HttpPut("EditarTipoProcesso")]
        public IActionResult EditarTipoProcesso([FromBody] TipoProcesso tipoProcesso)
        {
            try
            {
                var contato = _tipoProcessoServico.Atualizar(_mapper.Map<TipoProcesso>(tipoProcesso));
                return StatusCode(200, new { contato, mensagem = "Tipo de Processo editar com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao editar Tipo de Processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao editar Tipo de Processo!" });
            }
        }

        [HttpDelete("ExcluirTipoProcesso/{id}")]
        public IActionResult DeleteTipoProceso(int id)
        {
            try
            {
                var contato = _tipoProcessoServico.Excluir(id);
                return StatusCode(200, new { contato, mensagem = "Tipo de Processo inativado com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao inativar Tipo de Processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao inativar Tipo de Processo!" });
            }
        }

        [HttpGet("ConsultarTipoProcesso")]
        public IActionResult ListarTudoTipoProcesso()
        {
            try
            {
                var tipoProcesso = _tipoProcessoServico.ListarTudo();
                if (tipoProcesso.Count == 0)
                    return NoContent();
                return StatusCode(200, tipoProcesso);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar o Tipo de Processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar o Tipo de Processo!" });
            }
        }

        [HttpGet("BuscarTipoProcessoPorID/{id}")]
        public IActionResult GetTipoProcessoById(int id)
        {
            try
            {
                var buscar = _tipoProcessoServico.RetornaPorId(id);
                if (buscar == null)
                    return NoContent();
                return StatusCode(200, buscar);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar Tipo de Processo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar Tipo de Processo!" });
            }
        }


        // ***************** TIPO PRAZO *****************

        [HttpGet("ConsultarTipoPrazo")]
        public IActionResult ListarTudoTipoPrazo()
        {
            try
            {
                var tipoPrazo = _tipoPrazoServico.ListarTudo();
                if (tipoPrazo.Count == 0)
                    return NoContent();
                return StatusCode(200, tipoPrazo);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar o Tipo de Prazo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar o Tipo de Prazo!" });
            }
        }

        [HttpGet("BuscarTipoPrazoPorID/{id}")]
        public IActionResult GetTipoPrazoById(int id)
        {
            try
            {
                var buscar = _tipoPrazoServico.RetornaPorId(id);
                if (buscar == null)
                    return NoContent();
                return StatusCode(200, buscar);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar Tipo de Prazo!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar Tipo de Prazo!" });
            }
        }


        // ***************** TIPO USUÁRIO GERÊNCIA *****************

        [HttpGet("ConsultarTipoUsuarioGerencia")]
        public IActionResult ListarTudoTipoUsuarioGerencia()
        {
            try
            {
                var tipoUsuarioGerencia = _tipoUsuarioGerenciaServico.ListarTudo();
                if (tipoUsuarioGerencia.Count == 0)
                    return NoContent();
                return StatusCode(200, tipoUsuarioGerencia);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar o Tipo de Usuário da Gerência!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar o Tipo de Usuário da Gerência!" });
            }
        }

        [HttpGet("BuscarTipoUsuarioGerenciaPorID/{id}")]
        public IActionResult GetTipoUsuarioGerenciaById(int id)
        {
            try
            {
                var buscar = _tipoUsuarioGerenciaServico.RetornaPorId(id);
                if (buscar == null)
                    return NoContent();
                return StatusCode(200, buscar);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar Tipo de Usuário da Gerência!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar Tipo de Usuário da Gerência!" });
            }
        }

    }
}

