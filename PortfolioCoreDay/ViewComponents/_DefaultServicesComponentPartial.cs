using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultServicesComponentPartial:ViewComponent
    {
      PortfolioContext _context = new PortfolioContext();
    public IViewComponentResult Invoke()
    {
        var values = _context.Services.ToList(); 
        return View(values);
    }

    }
}
