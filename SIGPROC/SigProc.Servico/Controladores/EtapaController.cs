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
    public class EtapaController : ControllerBase
    {
        private readonly IEtapaProcessoServico _etapaProcessoServico;
        private IMapper _mapper;
        public EtapaController(IEtapaProcessoServico etapaProcessoServico, IMapper mapper)
        {
            _etapaProcessoServico = etapaProcessoServico;
            _mapper = mapper;
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
        public IActionResult DeleteTipoProceso(int id)
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
        public IActionResult ListarTudoTipoProcesso()
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
    }
}



/* using Microsoft.AspNetCore.Http;
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
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EtapasController : ControllerBase
    {
        private readonly IEtapasServico _etapasServico;
        private IMapper _mapper;
        public EtapasController(IEtapasServico etapasServico, IMapper mapper)
        {
            _etapasServico = etapasServico;
            _mapper = mapper;
        }

        [HttpPost("Cadastrar")]
        public IActionResult Post([FromBody] EtapasModelo etapas)
        {
            //var sUsuario = _usuarioServico.BuscarPorEmail(User.Identity.Name);
            try
            {

                var cadastro = _etapasServico.Inserir(_mapper.Map<EtapasController>(etapas));

                //Log.ForContext("Action", $"CadastrarU").Information($"O usuário: {sUsuario}, cadastrou o usuário: {usuario.Nome}.");
                return StatusCode(201, new { cadastro, mensagem = "Etapas cadastrada com sucesso!" });
            }
            catch (ValidationException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Errors, mensagem = "Erro ao cadastrar etapas!" });
            }
            catch (ArgumentException ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao cadastrar etapas!" });
            }
            catch (Exception ex)
            {
                //Log.ForContext("Action", $"Catalogos.Get").Information($"{sUsuario}, erro ao cadastrar a usuário {usuario.Nome}. - {ex.Message}");
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao cadastrar etapas!" });
            }
        }

        [HttpPut("Editar")]
        public IActionResult Editar([FromBody] EtapasController etapas)
        {
            try
            {
                var contato = _etapasServico.Atualizar(etapas);
                return StatusCode(200, new { contato, mensagem = "Etapa editada com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao editar etapas!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao editar etapas!" });
            }
        }

        [HttpDelete("Excluir/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var contato = _etapasServico.Excluir(id);
                return StatusCode(200, new { contato, mensagem = "Etapa inativada com sucesso!" });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao inativar etapa!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message, mensagem = "Erro ao inativar etapa!" });
            }
        }

        [HttpGet("Consultar")]
        public IActionResult ListarTudo()
        {
            try
            {
                var etapas = _etapasServico.ListarTudo();
                if (etapas.Count == 0)
                    return NoContent();

                return StatusCode(200, etapas);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao consultar etapas!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao consultar etapas!" });
            }
        }
        [HttpGet("BuscarPorID/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var etapas = _etapasServico.RetornaPorId(id);
                if (etapas == null)
                    return NoContent();

                return StatusCode(200, etapas);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message, mensagem = "Erro ao buscar etapa!" });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message, mensagem = "Erro ao buscar etapa!" });
            }
        }
    }
}
*/


