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
            var totalLicenciados = _licenciamentoRepository.GetTotalLicenciados(2023,new List<int>(225053),5,true);

            return View();
        }

        public IActionResult LicencasDeferidas()
        {
            var licencasDeferidas = _licenciamentoRepository.GetTotalLicencasDeferidas();

            return View();
        }
    }
}
