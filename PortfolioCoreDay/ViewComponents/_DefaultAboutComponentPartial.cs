using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var value = context.Abouts.FirstOrDefault(); 
            return View(value); 
        }
    }



}