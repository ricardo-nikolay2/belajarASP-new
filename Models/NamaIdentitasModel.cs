using System.ComponentModel.DataAnnotations;  /*sintak untuk validasi */
using belajarASP_new.Models;

namespace belajarASP_new.Models
{
    public class NamaIdentitasModel
    {
        [Required]
        [StringLength(10,MinimumLength =2 )]
        public string? Nama { get; set; }

        [Required]
        [Range(17, 65)]
        public int? Usia { get; set; }
    }





}
