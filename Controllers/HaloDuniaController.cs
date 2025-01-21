using Microsoft.AspNetCore.Mvc;
using belajarASP_new.Models; /*mengkoneksikan kelas model ke controller*/

namespace belajarASP_new.Controllers
{
    public class HaloDuniaController : Controller
    {
        public IActionResult Index()
        {
            NamaIdentitasModel namasaya = new NamaIdentitasModel() 
            {
                Nama = "Joni",

                Usia = 20
            };

            return View(namasaya);
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
