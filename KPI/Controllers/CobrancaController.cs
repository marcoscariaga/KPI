using Highsoft.Web.Mvc.Charts;
using KPI.Data;
using KPI.Models;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index(string ano)
        {
            #region Chart

            var result = _context.CobrancaSisvisas
               .Where(p => p.Situacao != 2 && p.Situacao != 3)
               //.Where(p => new[] { 2019, 2020, 2021, 2022, 2023 }.Contains(p.DtVencto1.Year)) // YEAR(DT_VENCTO_1) IN (2019,2020,2021,2022,2023)
               .Where(p => new[] { 5207, 5223, 5231, 5274 }.Contains(p.CdReceita)) // CD_RECEITA in (5207,5223,5231,5274)
               .GroupBy(p => new { p.CdReceita, Year = p.DtCompetencia.Year }) // GROUP BY CD_RECEITA, YEAR(DT_COMPETENCIA)
               .Select(group => new
               {
                   CdReceita = group.Key.CdReceita,
                   Ano = group.Key.Year,
                   VlPrincipal = group.Sum(p => p.VlPrincipal)
               })
               .OrderBy(p => p.Ano)
               .ToList();

            List<decimal> cd5207Values = new List<decimal>();
            List<decimal> cd5223Values = new List<decimal>();
            List<decimal> cd5231Values = new List<decimal>();
            List<decimal> cd5274Values = new List<decimal>();
            List<LineSeriesData> cd5207Data = new List<LineSeriesData>();
            List<LineSeriesData> cd5223Data = new List<LineSeriesData>();
            List<LineSeriesData> cd5231Data = new List<LineSeriesData>();
            List<LineSeriesData> cd5274Data = new List<LineSeriesData>();

            foreach (var item in result)
            {
                if (item.CdReceita == 5207)
                {
                    if (item.VlPrincipal >= 1000000)
                        cd5207Values.Add(item.VlPrincipal / 100);
                    else
                        cd5207Values.Add(item.VlPrincipal);
                }
                else if (item.CdReceita == 5223)
                {
                    if (item.VlPrincipal >= 1000000)
                        cd5223Values.Add(item.VlPrincipal / 100);
                    else
                        cd5223Values.Add(item.VlPrincipal);
                }
                else if (item.CdReceita == 5231)
                {
                    if (item.VlPrincipal >= 1000000)
                        cd5231Values.Add(item.VlPrincipal / 100);
                    else
                        cd5231Values.Add(item.VlPrincipal);
                }
                else if (item.CdReceita == 5274)
                {
                    if (item.VlPrincipal >= 1000000)
                        cd5274Values.Add(item.VlPrincipal / 100);
                    else
                        cd5274Values.Add(item.VlPrincipal);
                }
            }

            cd5207Values.ForEach(p => cd5207Data.Add(new LineSeriesData
            {
                Y = ((double)p)
            }));
            cd5223Values.ForEach(p => cd5223Data.Add(new LineSeriesData
            {
                Y = ((double)p)
            }));
            cd5231Values.ForEach(p => cd5231Data.Add(new LineSeriesData
            {
                Y = ((double)p)
            }));
            cd5274Values.ForEach(p => cd5274Data.Add(new LineSeriesData
            {
                Y = ((double)p)
            }));

            ViewData["cd5207Data"] = cd5207Data;
            ViewData["cd5223Data"] = cd5223Data;
            ViewData["cd5231Data"] = cd5231Data;
            ViewData["cd5274Data"] = cd5274Data;

            #endregion

            #region Table

            var cobrancaSisvisa = new List<CobrancaSisvisa>();
            decimal total = decimal.MinValue;

            if (ano != string.Empty && ano != null)
            {
                cobrancaSisvisa = _context.CobrancaSisvisas
                    .Where(p => p.DtVencto1.Year == Convert.ToInt32(ano))
                    .Where(p => p.Situacao != 2 && p.Situacao != 3)
                    .Where(p => p.CdReceita == 5207 || p.CdReceita == 5223 || p.CdReceita == 5231 || p.CdReceita == 5274)
                    .GroupBy(p => p.CdReceita)
                    .Select(group => new CobrancaSisvisa
                    {
                        CdReceita = group.Key,
                        VlPrincipal = group.Sum(p => p.VlPrincipal)
                    })
                    .OrderByDescending(p => p.VlPrincipal)
                    .ToList();
            }
            else
            {
                cobrancaSisvisa = _context.CobrancaSisvisas
                    .Where(p => p.DtVencto1.Year == DateTime.Now.Year)
                    .Where(p => p.Situacao != 2 && p.Situacao != 3)
                    .Where(p => p.CdReceita == 5207 || p.CdReceita == 5223 || p.CdReceita == 5231 || p.CdReceita == 5274)
                    .GroupBy(p => p.CdReceita)
                    .Select(group => new CobrancaSisvisa
                    {
                        CdReceita = group.Key,
                        VlPrincipal = group.Sum(p => p.VlPrincipal)
                    })
                    .OrderByDescending(p => p.VlPrincipal)
                    .ToList();
                ano = DateTime.Now.Year.ToString();
            }

            total = cobrancaSisvisa.Sum(item => item.VlPrincipal);

            ViewBag.Year = ano;
            ViewBag.Total = string.Format("{0:C}", total);

            #endregion

            return View(cobrancaSisvisa);
        }
    }
}
