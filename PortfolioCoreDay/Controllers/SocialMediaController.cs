using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly PortfolioContext _context;
        public SocialMediaController(PortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(SocialMedia social)
        {
            if (ModelState.IsValid)
            {
                _context.SocialMedias.Add(social);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(social);
        }

        public IActionResult Delete(int id)
        {
            var value = _context.SocialMedias.Find(id);
            _context.SocialMedias.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
