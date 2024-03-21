using Highsoft.Web.Mvc.Charts;
using KPI.Data;
using KPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
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

        public async Task<IActionResult> Index(string ano)
        {
            #region Chart

            var result = await _context.VisitasDeInspecaoDoEstabelecimentos
               .Where(p => new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }.Contains(p.DataVisita.Month))
               .GroupBy(p => new { p.DataVisita.Month, p.DataVisita.Year })
               .Select(group => new
               {
                   Month = group.Key.Month,
                   Year = group.Key.Year,
                   Total = group.Count(p => p.TermoVisitaSanitariaId != null)
               })
               .OrderBy(p => p.Year)
               .OrderBy(p => p.Month)
               .ToListAsync();

            List<LineSeriesData> ano2016Data = new List<LineSeriesData>();
            List<LineSeriesData> ano2017Data = new List<LineSeriesData>();
            List<LineSeriesData> ano2018Data = new List<LineSeriesData>();
            List<LineSeriesData> ano2019Data = new List<LineSeriesData>();
            List<LineSeriesData> ano2020Data = new List<LineSeriesData>();
            List<LineSeriesData> ano2021Data = new List<LineSeriesData>();
            List<LineSeriesData> ano2022Data = new List<LineSeriesData>();
            List<LineSeriesData> ano2023Data = new List<LineSeriesData>();
            List<LineSeriesData> ano2024Data = new List<LineSeriesData>();

            var total2016 = 0;
            var total2017 = 0;
            var total2018 = 0;
            var total2019 = 0;
            var total2020 = 0;
            var total2021 = 0;
            var total2022 = 0;
            var total2023 = 0;
            var total2024 = 0;

            foreach (var item in result)
            {
                if (item.Year == 2016)
                {
                    ano2016Data.Add(new LineSeriesData { X = item.Month - 1, Y = item.Total });
                    total2016 += item.Total;
                }
                else if (item.Year == 2017)
                {
                    ano2017Data.Add(new LineSeriesData { X = item.Month - 1, Y = item.Total });
                    total2017 += item.Total;
                }
                else if (item.Year == 2018)
                {
                    ano2018Data.Add(new LineSeriesData { X = item.Month - 1, Y = item.Total });
                    total2018 += item.Total;
                }
                else if (item.Year == 2019)
                {
                    ano2019Data.Add(new LineSeriesData { X = item.Month - 1, Y = item.Total });
                    total2019 += item.Total;
                }
                else if (item.Year == 2020)
                {
                    ano2020Data.Add(new LineSeriesData { X = item.Month - 1, Y = item.Total });
                    total2020 += item.Total;
                }
                else if (item.Year == 2021)
                {
                    ano2021Data.Add(new LineSeriesData { X = item.Month - 1, Y = item.Total });
                    total2021 += item.Total;
                }
                else if (item.Year == 2022)
                {
                    ano2022Data.Add(new LineSeriesData { X = item.Month - 1, Y = item.Total });
                    total2022 += item.Total;
                }
                else if (item.Year == 2023)
                {
                    ano2023Data.Add(new LineSeriesData { X = item.Month - 1, Y = item.Total });
                    total2023 += item.Total;
                }
                else if (item.Year == 2024)
                {
                    ano2024Data.Add(new LineSeriesData { X = item.Month - 1, Y = item.Total });
                    total2024 += item.Total;
                }
            }
                       
            ViewData["ano2016Data"] = ano2016Data; 
            ViewData["ano2017Data"] = ano2017Data;
            ViewData["ano2018Data"] = ano2018Data;
            ViewData["ano2019Data"] = ano2019Data;
            ViewData["ano2020Data"] = ano2020Data;
            ViewData["ano2021Data"] = ano2021Data;
            ViewData["ano2022Data"] = ano2022Data;
            ViewData["ano2023Data"] = ano2023Data;
            ViewData["ano2024Data"] = ano2024Data;

            ViewData["total2016Data"] = total2016;
            ViewData["total2017Data"] = total2017;
            ViewData["total2018Data"] = total2018;
            ViewData["total2019Data"] = total2019;
            ViewData["total2020Data"] = total2020;
            ViewData["total2021Data"] = total2021;
            ViewData["total2022Data"] = total2022;
            ViewData["total2023Data"] = total2023;
            ViewData["total2024Data"] = total2024;

            #endregion

            #region Table

            var visitasDeInspecaoDoEstabelecimento = new List<VisitasDeInspecaoDoEstabelecimento>();
            decimal total = decimal.MinValue;

            if (ano == string.Empty || ano == null)
                ano = DateTime.Now.Year.ToString(); //"2021";

            visitasDeInspecaoDoEstabelecimento = await _context.VisitasDeInspecaoDoEstabelecimentos
               .Where(p => new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }.Contains(p.DataVisita.Month))
               .Where(p => p.DataVisita.Year == Convert.ToInt32(ano))
               .GroupBy(p => new { p.DataVisita.Month, p.DataVisita.Year })
               .Select(group => new VisitasDeInspecaoDoEstabelecimento
               {
                   MesVisita = group.Key.Month,
                   AnoVisita = group.Key.Year,
                   Total = group.Count(p => p.TermoVisitaSanitariaId != null)
               })
               .OrderBy(p => p.AnoVisita)
               .OrderBy(p => p.MesVisita)
               .ToListAsync();

            total = visitasDeInspecaoDoEstabelecimento.Sum(item => item.Total);

            ViewBag.Year = ano;
            ViewBag.Total = total;

            #endregion

            return View(visitasDeInspecaoDoEstabelecimento);
        }
    }
}
