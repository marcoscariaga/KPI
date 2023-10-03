using KPI.Models;
using KPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace KPI.Controllers
{
    public class EventosController : Controller
    {
        private readonly EventoRepository _eventoRepository;

        public EventosController(EventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult<DashboardEventoModel>> EventoOrganizador(DateTime? ano)
        {
            if (ano == null)
                ano = DateTime.Now;

            var result = await _eventoRepository.GetEventoOrganizador(ano);

            return View(result);
        }
    }
}