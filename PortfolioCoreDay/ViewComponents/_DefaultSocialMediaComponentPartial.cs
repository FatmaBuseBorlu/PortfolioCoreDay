using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultSocialMediaComponentPartial: ViewComponent
    {
       private readonly PortfolioContext _context=new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = _context.SocialMedias
                  .OrderBy(x => x.Id) 
                  .ToList();
            return View(values);
        }
    }
}
