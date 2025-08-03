using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using System.Globalization;

namespace PortfolioCoreDay.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Skills.Sum(x => x.SkillValue);
            ViewBag.V3 = context.Skills.Average(x => x.SkillValue);
            ViewBag.V4 = context.Skills.Where(x => x.SkillValue > 80).Count();
            ViewBag.v5 = context.Skills.Count(x => x.SkillCategory == "Frontend");
            ViewBag.v6 = context.Skills.Count(x => x.SkillCategory == "Backend");
            ViewBag.v7 = context.Skills.Count(x => x.SkillDate.Year == 2025);
            ViewBag.v8 = context.Skills.OrderByDescending(x => x.SkillDate).Select(x => x.SkillName).FirstOrDefault();
            ViewBag.v9 = context.Skills.Select(x => x.SkillCategory).Distinct().Count();
            ViewBag.v10 = DateTime.Now.ToString("dd MMMM yyyy", new CultureInfo("tr-TR"));

            return View();
        }
    }
}
