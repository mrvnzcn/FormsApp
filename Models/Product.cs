namespace FormsApp.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public bool isActive { get; set; }
        public Guid CategoryId { get; set; }
    }
}

