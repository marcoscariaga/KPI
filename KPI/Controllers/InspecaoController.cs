using Highsoft.Web.Mvc.Charts;
using KPI.Data;
using KPI.Models;
using Microsoft.AspNetCore.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace KPI.Controllers
{
    public class InspecaoController : Controller
    {
        private readonly SisvisaContext _context;

        public InspecaoController(SisvisaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.VisitasDeInspecaoDoEstabelecimentos
               .Where(p => new[] { 1, 2, 3, 4, 5, 6, 7, 8, 910, 11, 12 }.Contains(p.DataVisita.Month))
               .Where(p => new[] { 2019, 2020, 2021, 2022, 2023 }.Contains(p.DataVisita.Year))
               .GroupBy(p => new { p.DataVisita.Month, p.DataVisita.Year })
               .Select(group => new
               {
                   Month = group.Key.Month,
                   Ano = group.Key.Year,
                   Total = group.Count(p => p.TermoVisitaSanitariaId != null)
               })
               .OrderBy(p => p.Ano)
//               .OrderBy(p => p.Month)
               .ToList();


           return View();
        }
    }
}
