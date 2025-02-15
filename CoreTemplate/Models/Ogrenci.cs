using System.ComponentModel.DataAnnotations;

namespace CoreTemplate.Models
{
    public class Ogrenci
    {
        [Required(ErrorMessage ="Zorunlu alan!")]
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public bool? Katilim { get; set; }
    }
}
