using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultMessageComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            PortfolioContext context = new PortfolioContext();
            var values = context.Messages.ToList(); 
            return View(values);
        }
    }
}
