using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/Page404")]
        public IActionResult Page404()
        {
            return View();
        }
    }
}
