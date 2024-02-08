using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name="Ürün Id")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Gerekli bir alan")]
        [StringLength(100)]
        [Display(Name="Ürün Adı")]
        public string? Name { get; set; }

        [Required]
        [Range(0, 100000)]
        [Display(Name="Fiyat")]
        public decimal? Price { get; set; }

        [Required]
        [Display(Name="Görsel")]
        public string? Image { get; set; } = string.Empty;

        
        public bool IsActive { get; set; }

        [Display(Name="Category")]
        [Required]
        public int? CategoryId { get; set; }
    }
}

