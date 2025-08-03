using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultContactComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {

            var contacts = context.Contacts.ToList(); 
            return View(contacts); 

        }
    }
}
