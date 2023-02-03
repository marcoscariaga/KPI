using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos.ModeloEntrada;
using SigProc.Domain.Entidades;

namespace SigProc.Servico.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly IUsuarioServico _usuarioServico;
        private IMapper _mapper;
        public AutenticacaoController(IUsuarioServico usuarioServico, IMapper mapper)
        {
            _usuarioServico = usuarioServico;
            _mapper = mapper;
        }

        [HttpPost("Logar")]
        public IActionResult Logar(AutenticacaoModelo model)
        {
            try
            {
                var usuario = _usuarioServico.Get(model.Email, model.Senha);
                if (usuario != null)
                {
                    var result = new
                    {
                        Mensagem = "Autenticação realizada com sucesso.",
                        AccessToken = _usuarioServico.GetAccessToken(_mapper.Map<Usuario>(model)),
                        Usuario = usuario
                    };
                    return Ok(result);
                }
                else
                {
                    //UNAUTHORIZED (HTTP 401)
                    return Unauthorized("Acesso negado.");
                }

            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
