using System.ComponentModel.DataAnnotations;

namespace ProductSales.Models
{
    public class Users
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required string Kontrol { get; set; }
    }
}
