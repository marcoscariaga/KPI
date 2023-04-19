using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SigProc.Aplicacao.Contratos;

namespace SigProc.Servico.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeriadosController : ControllerBase
    {
        private readonly IFeriadoServico _feriadoServico;

        public FeriadosController(IFeriadoServico feriadoServico)
        {
            _feriadoServico = feriadoServico;
        }

        [HttpGet("Consultar")]
        public IActionResult ListarTudo()
        {
            try
            {
                var feriados = _feriadoServico.ListarTudo();
                if (feriados.Count == 0)
                    return NoContent();

                return StatusCode(200, feriados);
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
