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

        public async Task<ActionResult<DashboardEventoModel>> EventoOrganizadorPeriodo()
        {
            var result = await _eventoRepository.GetEventoOrganizadorPeriodo();

            return View(result);
        }

        public async Task<ActionResult<DashboardEventoModel>> EventoFornecedor(DateTime? ano)
        {
            if (ano == null)
                ano = DateTime.Now;

            var result = await _eventoRepository.GetEventoFornecedor(ano);

            return View(result);
        }

        public async Task<ActionResult<DashboardEventoModel>> EventoFornecedorPeriodo()
        {
            var result = await _eventoRepository.GetEventoFornecedorPeriodo();

            return View(result);
        }

        public async Task<ActionResult<DashboardEventoModel>> EventoSemLSAT(DateTime? ano)
        {
            if (ano == null)
                ano = DateTime.Now;

            var result = await _eventoRepository.GetEventoSemLSAT(ano);

            return View(result);
        }

        public async Task<ActionResult<DashboardEventoModel>> EventoSemLSATPeriodo()
        {
            var result = await _eventoRepository.GetEventoSemLSATPeriodo();

            return View(result);
        }
    }
}