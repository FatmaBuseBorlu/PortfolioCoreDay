using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultEducationComponentPartial:ViewComponent
    {
        PortfolioContext _context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = _context.Educations.ToList(); 
            return View(values);
        }
    }
}
