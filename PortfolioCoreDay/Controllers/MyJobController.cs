using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class MyJobController : Controller
    {
        private readonly PortfolioContext _context;

        public MyJobController(PortfolioContext context)
        {
            _context = context;
        }

        // GET: Add sayfasını açar
        public IActionResult Add()
        {
            return View();
        }

        // POST: Formdan gelen veriyi kaydeder
        [HttpPost]
        public IActionResult Add(MyJob job)
        {
            _context.MyJobs.Add(job);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var values = _context.MyJobs.ToList();
            return View(values);
        }
    }
}
