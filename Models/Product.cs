using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name="Ürün Id")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name="Ürün Adı")]
        public string? Name { get; set; }

        [Display(Name="Fiyat")]
        public decimal Price { get; set; }

        [Display(Name="Görsel")]
        public string? Image { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Display(Name="Category")]
        public int CategoryId { get; set; }
    }
}

