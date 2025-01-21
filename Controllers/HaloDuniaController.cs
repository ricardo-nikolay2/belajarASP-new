using Microsoft.AspNetCore.Mvc;
using belajarASP_new.Models; /*mengkoneksikan kelas model ke controller*/

namespace belajarASP_new.Controllers
{
    public class HaloDuniaController : Controller
    {

        private static List<NamaIdentitasModel> datanama = new List<NamaIdentitasModel>();
        public IActionResult Index()
        {
            #region Codingan Lama
            //NamaIdentitasModel namasaya = new NamaIdentitasModel() 
            //{
            //    Nama = "Joni",

            //    Usia = 20
            //};
            #endregion

            return View(datanama);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Create()
        {
            var namaVM = new NamaIdentitasModel();
            return View(namaVM);

        }

        public IActionResult TambahNama (NamaIdentitasModel namaIdentitasModel) /*untuk membuat endpoint pada form di file Create.cshtml*/
        {
            if (ModelState.IsValid)
            {
                {
                    datanama.Add(namaIdentitasModel);
                    return RedirectToAction(nameof(Index));
                }
            }

            return View("About");
            
        }

        

        //public String Index()
        //{
        //    return "Ini adalah Halaman Depan Halo Dunia";
        //}
    }
}
