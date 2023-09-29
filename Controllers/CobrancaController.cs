using Highsoft.Web.Mvc.Charts;
using KPI.Data;
using KPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace KPI.Controllers
{
    public class CobrancaController : Controller
    {
        private readonly SisvisaContext _context;

        public CobrancaController(SisvisaContext context)
        {
                _context = context;
        }
        public async Task<IActionResult> Index(string ano)
        {
            #region Chart

            var codigoReceita = new[] { 5207, 5223, 5231, 5274 };

            var result = await _context.CobrancaSisvisas
               .Where(p => p.Situacao != 2 && p.Situacao != 3)
               .Where(p => codigoReceita.Contains(p.CdReceita))
               .GroupBy(p => new { p.CdReceita, Year = p.DtCompetencia.Year })
               .Select(group => new
               {
                   CdReceita = group.Key.CdReceita,
                   Year = group.Key.Year,
                   VlPrincipal = group.Sum(p => p.VlPrincipal)
               })
               .OrderBy(p => p.Year)
               .ToListAsync();

            List<LineSeriesData> cd5207Data = new List<LineSeriesData>();
            List<LineSeriesData> cd5223Data = new List<LineSeriesData>();
            List<LineSeriesData> cd5231Data = new List<LineSeriesData>();
            List<LineSeriesData> cd5274Data = new List<LineSeriesData>();

            foreach (var item in result)
            {
                if (item.CdReceita == 5207)
                {
                    if (item.VlPrincipal >= 1000000)
                        cd5207Data.Add(new LineSeriesData { Y = (double)(item.VlPrincipal / 100),  });
                    else
                        cd5207Data.Add(new LineSeriesData { Y = (double)(item.VlPrincipal) });
                }
                else if (item.CdReceita == 5223)
                {
                    if (item.VlPrincipal >= 1000000)
                        cd5223Data.Add(new LineSeriesData { Y = (double)(item.VlPrincipal / 100) });
                    else
                        cd5223Data.Add(new LineSeriesData { Y = (double)(item.VlPrincipal) });
                }
                else if (item.CdReceita == 5231)
                {
                    if (item.VlPrincipal >= 1000000)
                        cd5231Data.Add(new LineSeriesData { Y = (double)(item.VlPrincipal / 100) });
                    else
                        cd5231Data.Add(new LineSeriesData { Y = (double)(item.VlPrincipal) });
                }
                else if (item.CdReceita == 5274)
                {
                    if (item.VlPrincipal >= 1000000)
                        cd5274Data.Add(new LineSeriesData { Y = (double)(item.VlPrincipal / 100) });
                    else
                        cd5274Data.Add(new LineSeriesData { Y = (double)(item.VlPrincipal) });
                }
            }

            ViewData["cd5207Data"] = cd5207Data;
            ViewData["cd5223Data"] = cd5223Data;
            ViewData["cd5231Data"] = cd5231Data;
            ViewData["cd5274Data"] = cd5274Data;

            #endregion

            #region Table

            var cobrancaSisvisa = new List<CobrancaSisvisa>();
            decimal total = decimal.MinValue;

            if (ano == string.Empty || ano == null)
                ano = DateTime.Now.Year.ToString();

            cobrancaSisvisa = await _context.CobrancaSisvisas
                .Where(p => p.DtVencto1.Year == Convert.ToInt32(ano))
                .Where(p => p.Situacao != 2 && p.Situacao != 3)
                .Where(p => codigoReceita.Contains(p.CdReceita))
                .GroupBy(p => p.CdReceita)
                .Select(group => new CobrancaSisvisa
                {
                    CdReceita = group.Key,
                    VlPrincipal = group.Sum(p => p.VlPrincipal)
                })
                .OrderByDescending(p => p.VlPrincipal)
                .ToListAsync();

            total = cobrancaSisvisa.Sum(item => item.VlPrincipal);

            ViewBag.Year = ano;
            ViewBag.Total = string.Format("{0:C}", total);

            #endregion

            return View(cobrancaSisvisa);
        }
    }
}
