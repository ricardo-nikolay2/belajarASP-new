using Microsoft.AspNetCore.Mvc;

namespace belajarASP_new.Controllers
{
    public class HaloDuniaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        //public String Index()
        //{
        //    return "Ini adalah Halaman Depan Halo Dunia";
        //}
    }
}
