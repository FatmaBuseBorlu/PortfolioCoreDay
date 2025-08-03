using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultStatisticComponentPartial : ViewComponent
    {
     
        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    }
}
