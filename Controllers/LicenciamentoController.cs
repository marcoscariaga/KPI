using KPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace KPI.Controllers
{
    public class LicenciamentoController : Controller
    {
        private readonly LicenciamentoRepository _licenciamentoRepository;

        public LicenciamentoController(LicenciamentoRepository licenciamentoRepository)
        {
            _licenciamentoRepository = licenciamentoRepository;
        }

        public IActionResult Index()
        {
            var totalLicenciados = _licenciamentoRepository.GetTotalLicencasDeferidas();

            return View();
        }
    }
}
