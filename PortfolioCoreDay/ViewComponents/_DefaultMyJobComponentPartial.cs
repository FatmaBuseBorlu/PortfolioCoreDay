using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultMyJobComponentPartial:ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultMyJobComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var jobs = _context.MyJobs.OrderByDescending(x => x.Date).ToList();
            return View(jobs);
        }
    }
}
