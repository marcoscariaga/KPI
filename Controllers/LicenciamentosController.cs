using Highsoft.Web.Mvc.Charts;
using KPI.Models;
using KPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KPI.Controllers
{
    public class LicenciamentosController : Controller
    {
        private readonly LicenciamentoRepository _licenciamentoRepository;

        public LicenciamentosController(LicenciamentoRepository licenciamentoRepository)
        {
            _licenciamentoRepository = licenciamentoRepository;
        }

        public async Task<IActionResult> Index()
        {
            var ano = 2024;
            var listaCodigosSegmento = new[] { 229067, 225053, 225738, 225746 };
            var idSegmento = 5;
            var atividadeLicenciada = 1;

            var totalLicenciados = await _licenciamentoRepository.GetTotalLicenciados(ano, listaCodigosSegmento, idSegmento, atividadeLicenciada);

            return View(totalLicenciados);
        }

        public async Task<ActionResult<DashboardLicenciamentoModel>> LicencasDeferidas()
        {
            int ano = 2024;
            int situacao = 7;
            ViewBag.Ano = ano;

            var result = await _licenciamentoRepository.GetTotalLicencasDeferidas(ano, situacao);

            return View(result);
        }
    }
}
