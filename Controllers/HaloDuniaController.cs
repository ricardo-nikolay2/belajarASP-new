using Microsoft.AspNetCore.Mvc;

namespace belajarASP_new.Controllers
{
    public class HaloDuniaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
