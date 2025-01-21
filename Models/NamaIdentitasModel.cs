using System.ComponentModel.DataAnnotations;
using belajarASP_new.Models;

namespace belajarASP_new.Models
{
    public class NamaIdentitasModel
    {
        [Required]
        public string? Nama { get; set; } 
        public int Usia { get; set; }
    }







}
