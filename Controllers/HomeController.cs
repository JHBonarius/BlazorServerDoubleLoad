using Microsoft.AspNetCore.Mvc;

namespace BlazorServerDoubleLoad.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
