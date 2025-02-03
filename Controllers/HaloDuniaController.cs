using Microsoft.AspNetCore.Mvc;
using belajarASP_new.Models;
using System.Reflection.Metadata.Ecma335; /*mengkoneksikan kelas model ke controller*/

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

        public IActionResult TidakValid()
        {
            return View();
        }

        public IActionResult TambahNama (NamaIdentitasModel namaIdentitasModel) /*untuk membuat endpoint pada form di file Create.cshtml*/
        {
            if (ModelState.IsValid) /*sintak untuk validasi pada input NAMA dan UMUR*/
            {
                
                    datanama.Add(namaIdentitasModel);
                    return RedirectToAction(nameof(Index));
                
            }


            //return View("About"); 
            //return Content("Data Tidak Valid", "Text/ Plain");

            return View("TidakValid");
            
        }

        

        //public String Index()
        //{
        //    return "Ini adalah Halaman Depan Halo Dunia";
        //}
    }
}
