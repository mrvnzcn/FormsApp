using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name="Ürün Id")]
        public Guid ProductId { get; set; }
        [Display(Name="Ürün Adı")]
        public string? Name { get; set; }
        [Display(Name="Fiyat")]
        public decimal Price { get; set; }
        [Display(Name="Görsel")]
        public string? Image { get; set; }
        public bool isActive { get; set; }
        public Guid CategoryId { get; set; }
    }
}

